using Ex1.Models;

namespace Ex2
{
    public class Method
    {
        public void Show()
        {
            var Result1 = Class.Classes
                .Select(c => new { c.Name, Count = Student.Students.Count(s => s.ClassId == c.Id) });
            var Result2 = Class.Classes
                .GroupJoin(Student.Students, c => c.Id, s => s.ClassId, (c, ss) => new { c.Name, Count = ss.Count() });

            Console.WriteLine("Solution 1: ");
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