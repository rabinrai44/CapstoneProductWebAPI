using ProductWebAPI.Data.Models;
using ProductWebAPI.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductWebAPI.Controllers
{
    public class TestController : ApiController
    {
        private IProductService productService = new ProductService();

        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            return productService.GetProducts();
        }

        // GET: api/Product/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult Get(int id)
        {
            var product = productService.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
