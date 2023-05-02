using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task280423.Models
{
    public class BaseEntity
    {
        public BaseEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public int Id { get; set; }
        public string Name { get; set; }
    }
}
