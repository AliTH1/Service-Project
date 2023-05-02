using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task280423.Models;

namespace Task280423.Services.Interfaces.ProductInterface
{
    internal interface IProductService
    {
        public void Create(int id, string name);
        public void Delete(string name);
        public Product GetById(string id);
    }
}
