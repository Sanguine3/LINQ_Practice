using Ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5

{
    class Query
    {
        public static void Show()
        {
            var Result1 =
                from c in Class.Classes
                select new
                {
                    c.Name,
                    first = Student.Students.FirstOrDefault(s => s.ClassId == c.Id)?.Name
                };
            var Result2 =
                from c in Class.Classes
                join s in Student.Students
                on c.Id equals s.ClassId into ss
                select new
                {
                    c.Name,
                    first = ss.FirstOrDefault(s => s.ClassId == c.Id)?.Name
                };

            Console.WriteLine("Solution 1: ");
            foreach (var item in Result1)
            {
                if (item.first == null)
                {
                    Console.WriteLine($"{item.Name}, null");
                }
                else
                    Console.WriteLine($"{item.Name}, {item.first}");
            }

            Console.WriteLine("Solution 2: ");
            foreach (var item in Result2)
            {
                if (item.first == null)
                {
                    Console.WriteLine($"{item.Name}, null");
                }
                else
                    Console.WriteLine($"{item.Name}, {item.first}");
            }
        }
    }
}
