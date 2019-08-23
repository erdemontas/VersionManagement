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
    public class CustomerController : ControllerBase
    {

        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public CustomerController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        // GET: api/Customer
        [HttpGet]
        public ActionResult<List<CustomerDTO>> Get(bool includeDeleted = false) => Ok(mapper.Map<IEnumerable<CustomerDTO>>(repoWrapper.Customer.GetByCondition(x => x.IsActive)));

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "GetCustomer")]
        public ActionResult<CustomerDTO> Get(Guid id) => Ok(mapper.Map<CustomerDTO>(repoWrapper.Customer.GetById(id)));

        // GET: api/ChangeLogType/undeleted
        [HttpGet("undeleted", Name = "GetCustomerUndeleted")]
        public ActionResult<List<CustomerDTO>> GetUndeleted() => Ok(mapper.Map<IEnumerable<CustomerDTO>>(repoWrapper.Customer.GetByCondition(x => x.IsDeleted == false)));

        // POST: api/Customer
        [HttpPost]
        public ActionResult Post([FromBody] CustomerDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.Customer.Insert(mapper.Map<Customer>(value));
            repoWrapper.Save();
            return Ok();
        }
        //TBC
        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] CustomerDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Doesnt exist.");
            var customer = repoWrapper.Customer.GetById(id);
            if (customer == null) return BadRequest();
            mapper.Map<CustomerDTO, Customer>(value, customer);
            repoWrapper.Save();
            return Ok();
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            Customer cust = repoWrapper.Customer.GetById(id);
            if (cust == null) return BadRequest();
            cust.IsDeleted = true;
            repoWrapper.Save();
            return Ok();
        }
    }
}
