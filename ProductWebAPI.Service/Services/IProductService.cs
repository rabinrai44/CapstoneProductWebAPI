using ProductWebAPI.Data;
using ProductWebAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebAPI.Service.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
    }
}