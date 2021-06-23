using APIOdata.Models;
using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIOdata.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet]
        [EnableQuery]
        public List<Product> GetList()
        {
            List<Product> _product = new List<Product>();
            _product.Add(new Product { Id = 1, Name = "A" });
            _product.Add(new Product { Id = 2, Name = "B" });
            return _product;//.Where(x=>x.Id == id).ToList();
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
