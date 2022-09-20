using Ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Query
    {
        public static void Show()
        {
            var QueryResult = from s in Student.Students
                              select new
                              {
                                  s.Id,
                                  s.ClassId
                              };

            Console.Write("Result: ");
            foreach (var item in QueryResult)
            {
                Console.WriteLine($"{item.Id}, {item.ClassId}");
            }
        }
    }
}
