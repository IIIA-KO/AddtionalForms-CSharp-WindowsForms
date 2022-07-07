using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }

        public Product(string name, double price, string description)
        {
            Name = name; Price = price; Description = description;
        }

        public override string ToString() => Name;
    }
}
