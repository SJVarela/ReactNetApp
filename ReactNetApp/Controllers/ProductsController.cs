using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private IProductsService productsService;
        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(productsService.GetAll());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            return Ok(productsService.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
