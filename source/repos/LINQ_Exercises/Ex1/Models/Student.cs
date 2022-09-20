using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ClassId { get; set; }

        public static List<Student> Students = new List<Student>()
        {
            new Student() { Id = 11, Name = "st1", ClassId = 1 },
            new Student() { Id = 12, Name = "st2", ClassId = 1 },
            new Student() { Id = 13, Name = "st3", ClassId = 2 }
        };
    }
}
