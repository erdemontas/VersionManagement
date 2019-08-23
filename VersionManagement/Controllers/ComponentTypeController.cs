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
    public class ComponentTypeController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public ComponentTypeController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }

        // GET: api/ComponentType
        [HttpGet]
        public ActionResult<List<ComponentTypeDTO>> Get(bool includeDeleted = false) => Ok(mapper.Map<IEnumerable<ComponentTypeDTO>>(repoWrapper.ComponentType.GetByCondition(x => x.IsActive).ToList()));
        // GET: api/ComponentType/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<ComponentTypeDTO> Get(Guid id) => Ok(mapper.Map<ComponentTypeDTO>(repoWrapper.ComponentType.GetById(id)));
        // GET: api/ComponentType/undeleted
        [HttpGet("undeleted", Name = "GetComponentTypeUndeleted")]
        public ActionResult<List<ComponentTypeDTO>> GetUndeleted() => Ok(mapper.Map<IEnumerable<ComponentTypeDTO>>(repoWrapper.ComponentType.GetByCondition(x => x.IsDeleted == false)));

        // POST: api/ComponentType
        [HttpPost]
        public ActionResult Post([FromBody] ComponentTypeDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.ComponentType.Insert(mapper.Map<ComponentType>(value));
            repoWrapper.Save();
            return Ok();
        }

        // PUT: api/ComponentType/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] ComponentTypeDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Doesnt exist.");
            var componentType = repoWrapper.ComponentType.GetById(id);
            if (componentType == null) return BadRequest();
            mapper.Map<ComponentTypeDTO, ComponentType>(value, componentType);
            repoWrapper.Save();
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            ComponentType cmpt = repoWrapper.ComponentType.GetById(id);
            if (cmpt == null) return BadRequest();
            cmpt.IsDeleted = true;
            repoWrapper.Save();
            return Ok();
        }
    }
}
