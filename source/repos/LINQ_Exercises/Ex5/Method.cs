using Ex1.Models;

namespace Ex2
{
    internal class Method
    {
        public static void Show()
        {
            var Result1 = Class.Classes
                .Select(c => new { c.Name, first = Student.Students.FirstOrDefault(s => s.ClassId == c.Id)?.Name });
            var Result2 = Class.Classes
                .GroupJoin(Student.Students, c => c.Id, s => s.ClassId, (c, stu) => new { c.Name, first = stu.Select(s => s.Name).FirstOrDefault() });

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