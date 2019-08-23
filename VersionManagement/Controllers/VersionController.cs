using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VersionManagement.DTOs;
using VersionManagement.Interfaces;

namespace VersionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public VersionController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        // GET: api/Version
        [HttpGet]
        public ActionResult<List<VersionDTO>> Get(bool includeDeleted) => Ok(mapper.Map<IEnumerable<VersionDTO>>(repoWrapper.Version.GetByCondition(x => x.IsActive)));

        // GET: api/Version/5
        [HttpGet("{id}", Name = "GetVersion")]
        public ActionResult<VersionDTO> Get(Guid id)
        {
            VersionDTO verd = mapper.Map<VersionDTO>(repoWrapper.Version.GetById(id));
            verd.Component = mapper.Map<ComponentDTO>(repoWrapper.Component.GetById(verd.ComponentId.GetValueOrDefault()));
            return Ok(verd);
        }
        // POST: api/Version
        [HttpPost]
        public ActionResult Post([FromBody] VersionDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.Version.Insert(mapper.Map<Models.Version>(value));
            repoWrapper.Save();
            return Ok();
        }
        // PUT: api/Version/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] VersionDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Doesnt exist.");
            var version = repoWrapper.Version.GetById(id);
            if (version == null) return BadRequest();
            mapper.Map<VersionDTO, Models.Version>(value, version);
            repoWrapper.Save();
            return Ok();
        }

        // DELETE: api/Version/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            Models.Version ver = repoWrapper.Version.GetById(id);
            if (ver == null) return BadRequest();
            ver.IsDeleted = true;
            repoWrapper.Save();
            return Ok();
        }
    }
}
