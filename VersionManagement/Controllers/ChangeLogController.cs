using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    public class ChangeLogController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public ChangeLogController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        // GET: api/ChangeLog
        [HttpGet]
        public ActionResult<List<ChangeLogDTO>> Get(bool includeDeleted = false) => Ok(mapper.Map<IEnumerable<LiteChangeLogDTO>>(repoWrapper.ChangeLog.GetByCondition(x => !x.IsDeleted).ToList()));
        // GET: api/ChangeLog/5
        [HttpGet("{id}", Name = "GetChangeLog")]
        public ActionResult<ChangeLogDTO> Get(Guid id)
        {
            ChangeLogDTO cld = mapper.Map<ChangeLogDTO>(repoWrapper.ChangeLog.GetById(id));
            cld.Version = mapper.Map<VersionDTO>(repoWrapper.Version.GetById(cld.VersionId.GetValueOrDefault()));
            cld.ChangeLogType = mapper.Map<ChangeLogTypeDTO>(repoWrapper.ChangeLogType.GetById(cld.ChangeLogTypeId.GetValueOrDefault()));
            return Ok(cld);
        }
        // POST: api/ChangeLog
        [HttpPost]
        public ActionResult Post([FromBody] ChangeLogDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.ChangeLog.Insert(mapper.Map<ChangeLog>(value));
            repoWrapper.Save();
            return Ok();
        }


        //TBC
        // PUT: api/ChangeLog/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] ChangeLogDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Doesnt exist.");
            var changeLog = repoWrapper.ChangeLog.GetById(id);
            if (changeLog == null) return BadRequest();
            mapper.Map<ChangeLogDTO,ChangeLog>(value,changeLog);
            repoWrapper.Save();
            return Ok();
        }

        // DELETE: api/ChangeLog/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            ChangeLog cl = repoWrapper.ChangeLog.GetById(id);
            if (cl == null) return BadRequest();
            cl.IsDeleted = true;
            repoWrapper.Save();
            return Ok();
        }
    }
}
