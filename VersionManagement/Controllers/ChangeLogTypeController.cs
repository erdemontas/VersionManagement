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
    public class ChangeLogTypeController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public ChangeLogTypeController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        // GET: api/ChangeLogType
        [HttpGet]
        public ActionResult<List<ChangeLogTypeDTO>> Get(bool includeDeleted = false) => Ok(mapper.Map<IEnumerable<ChangeLogTypeDTO>>(repoWrapper.ChangeLogType.GetByCondition(x => x.IsActive).ToList()));
        // GET: api/ChangeLogType/5
        [HttpGet("{id}", Name = "GetChangeLogType")]
        public ActionResult<ChangeLogTypeDTO> Get(Guid id) => Ok(mapper.Map<ChangeLogTypeDTO>(repoWrapper.ChangeLogType.GetById(id)));

        // POST: api/ChangeLogType
        [HttpPost]
        public ActionResult Post([FromBody] ChangeLogTypeDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.ChangeLogType.Insert(mapper.Map<ChangeLogType>(value));
            repoWrapper.Save();
            return Ok();
        }
        // TBC
        // PUT: api/ChangeLogType/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] ChangeLogTypeDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Doesnt exist.");
            var changeLogType = repoWrapper.ChangeLogType.GetById(id);
            if (changeLogType == null) return BadRequest();
            mapper.Map<ChangeLogTypeDTO, ChangeLogType>(value, changeLogType);
            repoWrapper.Save();
            return Ok();
        }

        // DELETE: api/ChangeLogType/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            ChangeLogType clt = repoWrapper.ChangeLogType.GetById(id);
            if (clt == null) return BadRequest();
            clt.IsDeleted = true;
            repoWrapper.Save();
            return Ok();
        }
    }
}
