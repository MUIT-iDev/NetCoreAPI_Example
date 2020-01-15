using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreAPI_example.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public Product Get()
        {
            return new Product
            {
                Id = 111,
                Name = "iAmYacul",
                Price = 9999
            };
        }

        [HttpGet("GetList")]
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>();
        }

        [HttpPost]
        public Product CreateNewProduct([FromBody]Product data)
        {
            //insert new product to DB
            //return "Create " + data.Name + " Done";

            data.Id = 99;
            return data;
        }

        [HttpPut]
        public string ChangeProductName([FromBody]Product data)
        {

            //update product name in DB

            return "Update Product Name " + data.Name + " Success";
        }
    }
}
