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
    public class ProductController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public ProductController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        // GET: api/Product
        [HttpGet]
        public ActionResult<List<ProductDTO>> Get(bool includeDeleted = false) => Ok(mapper.Map<IEnumerable<ProductDTO>>(repoWrapper.Product.GetByCondition(x => x.IsActive).ToList()));

        // GET: api/Product/5
        [HttpGet("{id}", Name = "GetProduct")]
        public ActionResult<ProductDTO> Get(Guid id) => Ok(mapper.Map<ProductDTO>(repoWrapper.Product.GetById(id)));
        // POST: api/Product
        [HttpPost]
        public ActionResult Post([FromBody] ProductDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.Product.Insert(mapper.Map<Product>(value));
            repoWrapper.Save();
            return Ok();
        }
        //TBC
        // PUT: api/Product/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] ProductDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Doesnt exist.");
            var product = repoWrapper.Product.GetById(id);
            if (product == null) return BadRequest();
            mapper.Map<ProductDTO, Product>(value, product);
            repoWrapper.Save();
            return Ok();
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            Product prod = repoWrapper.Product.GetById(id);
            if (prod == null) return BadRequest();
            prod.IsDeleted = true;
            repoWrapper.Save();
            return Ok();
        }
    }
}
