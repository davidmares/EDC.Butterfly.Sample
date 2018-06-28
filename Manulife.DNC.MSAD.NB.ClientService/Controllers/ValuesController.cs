﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manulife.DNC.MSAD.NB.ClientService.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manulife.DNC.MSAD.NB.ClientService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ProductService productService;

        public ValuesController(ProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        [Route("api/[controller]/products")]
        public async Task<string> GetProducts(string _productType)
        {
            var result = await productService.GetAllProductsAsync(_productType);

            return result;
        }

        //private static int _count = 0;
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //_count++;
            //Console.WriteLine($"Get...{_count}");
            //if (_count <= 4)
            //{
            //    System.Threading.Thread.Sleep(5000);
            //}

            return new string[] { $"ClinetService: {DateTime.Now.ToString()} {Environment.MachineName} " +
                $"OS: {Environment.OSVersion.VersionString}" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
