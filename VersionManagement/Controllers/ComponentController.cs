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
    public class ComponentController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public ComponentController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        // GET: api/Component
        [HttpGet]
        public ActionResult<List<ComponentDTO>> Get(bool includeDeleted = false) => Ok(mapper.Map<IEnumerable<ComponentDTO>>(repoWrapper.Component.GetByCondition(x => x.IsActive).ToList()));

        // GET: api/Component/5
        [HttpGet("{id}", Name = "GetComponent")]
        public ActionResult<ComponentDTO> Get(Guid id) => Ok(mapper.Map<ComponentDTO>(repoWrapper.Component.GetById(id)));
        // POST: api/Component
        [HttpPost]
        public ActionResult Post([FromBody] ComponentDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.Component.Insert(mapper.Map<Component>(value));
            repoWrapper.Save();
            return Ok();
        }

        // PUT: api/Component/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] ComponentDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Doesnt exist.");
            var component = repoWrapper.Component.GetById(id);
            if (component == null) return BadRequest();
            mapper.Map<ComponentDTO, Component>(value, component);
            repoWrapper.Save();
            return Ok();
        }

        // DELETE: api/Component/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            Component cmp = repoWrapper.Component.GetById(id);
            if (cmp == null) return BadRequest();
            cmp.IsDeleted = true;
            repoWrapper.Save();
            return Ok();
        }
    }
}
