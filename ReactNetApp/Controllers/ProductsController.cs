﻿using Microsoft.AspNetCore.Mvc;
using ReactNetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactNetApp.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        protected StoreContext dbContext;
        public ProductsController(StoreContext context)
        {
            dbContext = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Json(dbContext.Products.ToArray());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
