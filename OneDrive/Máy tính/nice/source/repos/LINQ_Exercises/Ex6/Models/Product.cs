using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public static List<Product> list1 = new List<Product>()
        {
                        new Product() { Id = 1, Name = "c1" },
                        new Product() { Id = 2, Name = "c2" },
                        new Product() { Id = 3, Name = "c3" }
        };
    }
}
