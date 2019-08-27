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
    public class CustomerProductController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public CustomerProductController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        // GET: api/CustomerProduct
        [HttpGet]
        public ActionResult<List<CustomerProductDTO>> Get(bool includeDeleted = false) => Ok(mapper.Map<IEnumerable<CustomerProductDTO>>(repoWrapper.CustomerProduct.GetByCondition(x => x.IsActive).ToList()));

        // GET: api/CustomerProduct/5
        [HttpGet("{id}", Name = "GetCustomerProduct")]
        public ActionResult<CustomerProductDTO> Get(Guid id) => Ok(mapper.Map<CustomerProductDTO>(repoWrapper.CustomerProduct.GetById(id)));
        [HttpGet("GetByProductId/{id}", Name = "GetCustomerProductByProductId")]
        public ActionResult<List<CustomerProductDTO>> GetByProductId(Guid id) => Ok(mapper.Map<IEnumerable<CustomerProductDTO>>(repoWrapper.CustomerProduct.GetByCondition(x => x.ProductId == id).ToList()));
        [HttpGet("GetByCustomerId/{id}", Name = "GetCustomerProductByCustomerId")]
        public ActionResult<List<CustomerProductDTO>> GetByCustomerId(Guid id) => Ok(mapper.Map<IEnumerable<CustomerProductDTO>>(repoWrapper.CustomerProduct.GetByCondition(x => x.CustomerId == id).ToList()));
        // POST: api/CustomerProduct
        [HttpPost]
        public ActionResult Post([FromBody] CustomerProductDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.CustomerProduct.Insert(mapper.Map<CustomerProduct>(value));
            repoWrapper.Save();
            return Ok();
        }
        //TBC
        // PUT: api/CustomerProduct/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] CustomerProductDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Doesnt exist.");
            var customerProduct = repoWrapper.CustomerProduct.GetById(id);
            if (customerProduct == null) return BadRequest();
            mapper.Map<CustomerProductDTO, CustomerProduct>(value, customerProduct);
            repoWrapper.Save();
            return Ok();
        }

        // DELETE: api/CustomerProduct/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            CustomerProduct cp = repoWrapper.CustomerProduct.GetById(id);
            if (cp == null) return BadRequest();
            cp.IsDeleted = true;
            repoWrapper.Save();
            return Ok();
        }
    }
}
