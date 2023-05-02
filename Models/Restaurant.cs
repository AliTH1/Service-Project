using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task280423.Models
{
    public class Restaurant : BaseEntity
    {

        public List<Product> products = new List<Product>();

        public Restaurant(int id, string name) : base(id, name)
        {
        }
    }
}
