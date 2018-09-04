using ProductWebAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebAPI.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly NorthwindEntities db = new NorthwindEntities();

        public Product GetProduct(int id)
        {
            return db.Products.Where(x => x.ProductID == id).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
    }
}