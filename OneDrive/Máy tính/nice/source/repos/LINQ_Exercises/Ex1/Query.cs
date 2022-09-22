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
                                  ClassId = from c in Class.Classes
                                            select new
                                            {
                                                c.Id,
                                            }
                              };

            Console.Write("Result: \n");
            foreach (var item in QueryResult)
            {
                foreach (var item3 in item.ClassId)
                {
                    foreach (var item2 in QueryResult)
                    {
                        Console.WriteLine($"{item2.Id}, {item3.Id}");
                    }
                }
                break;
            }
        }
    }
}

