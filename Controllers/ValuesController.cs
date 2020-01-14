using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreAPI_example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /* comment init 
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        { 
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */

        [HttpGet]
        public string Get()
        {
            return "Hello, World XXX";
        }

        [HttpGet("{name}")]
        public string Get(string name)
        {
            return "Hello, " + name;
        }

        [HttpPost("{productName}")]
        public string CreateNewProduct(string productName)
        {
            // insert to DB
            return "Done";
        }

        [HttpPut]
        public string ChangeProductName(string productName)
        {
            // update product name in DB
            return "Update Product Name Done";
        }
    }
}
