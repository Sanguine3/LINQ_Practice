using Ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Query
    {
        public void Show()
        {
            var Result1 =
                from c in Class.Classes
                select new
                {
                    c.Name,
                    Count = Student.Students.Count(s => s.ClassId == c.Id)
                };
            var Result2 =
                from c in Class.Classes
                join s in Student.Students
                on c.Id equals s.ClassId into ss
                select new
                {
                    c.Name,
                    Count = ss.Count()
                };

            Console.WriteLine("Solution 1:");
            foreach (var item in Result1)
            {
                Console.WriteLine($"{item.Name}, {item.Count}");
            }

            Console.WriteLine("Solution 2: ");
            foreach (var item in Result2)
            {
                Console.WriteLine($"{item.Name}, {item.Count}");
            }
        }
    }
}
