using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex1.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public static List<Class> Classes = new List<Class>()
        {
                        new Class() { Id = 1, Name = "c1" },
                        new Class() { Id = 2, Name = "c2" },
                        new Class() { Id = 3, Name = "c3" }
        };
    }
}
