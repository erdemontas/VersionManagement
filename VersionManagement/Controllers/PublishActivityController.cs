using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VersionManagement.DTOs;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishActivityController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public PublishActivityController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        // GET: api/PublishActivity
        [HttpGet]
        public ActionResult<List<PublishActivityDTO>> Get(bool includeDeleted = false) => Ok(mapper.Map<IEnumerable<LitePublishActivityDTO>>(repoWrapper.PublishActivity.GetByCondition(x => x.IsActive)));

        // GET: api/PublishActivity/5
        [HttpGet("{id}", Name = "GetPublishActivity")]
        public ActionResult<PublishActivityDTO> Get(Guid id) => mapper.Map<PublishActivityDTO>(repoWrapper.PublishActivity.GetById(id));
        // POST: api/PublishActivity
        [HttpPost]
        public ActionResult Post([FromBody] PublishActivityDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.PublishActivity.Insert(mapper.Map<PublishActivity>(value));
            repoWrapper.Save();
            return Ok();
        }

        // PUT: api/PublishActivity/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] PublishActivityDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Doesnt exist.");
            var publishActivity = repoWrapper.PublishActivity.GetById(id);
            if (publishActivity == null) return BadRequest();
            mapper.Map<PublishActivityDTO, PublishActivity>(value, publishActivity);
            repoWrapper.Save();
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            PublishActivity pa = repoWrapper.PublishActivity.GetById(id);
            if (pa == null) return BadRequest();
            pa.IsDeleted = true;
            repoWrapper.Save();
            return Ok();
        }
    }
}
