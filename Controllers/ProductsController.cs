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
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return new Product
            {
                Id = id,
                Name = "iAmYacul",
                Price = 9999
            };
        }

        [HttpGet]
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

        [HttpPut("{id}")]
        public string ChangeProductName([FromBody]Product data, int id)
        {

            //update product name in DB

            return "Update Product Name " + data.Name + " where ID = " + id + " Success";
        }

        [HttpDelete("{id}")]
        public string RemoveProduct(int id)
        {
            //delete product in DB
            return "Removed Product ID: " + id;
        }
    }
}
