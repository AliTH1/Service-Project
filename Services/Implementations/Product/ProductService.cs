using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task280423.Models;
using Task280423.Services.Interfaces.ProductInterface;

namespace Task280423.Services.Implementations.Product
{
    internal class ProductService : IProductService
    {
        List<Models.Product> products = new List<Models.Product>();

        public void Create(int id, string name)
        {
            Models.Product product = new(id, name);
            product.Name = name;
            products.Add(product);
        }

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public Models.Product GetById(string id)
        {
            throw new NotImplementedException();
        }


    }
}
