using Ex1.Models;

namespace Ex1_Method
{
    internal class Method
    {
        public static void Show()
        {
            var MethodResult = Student.Students.Select(s => new {s.Id, s.ClassId});

            Console.Write("Result: ");
            foreach (var item in MethodResult)
            {
                Console.WriteLine($"{item.Id}, {item.ClassId}");
            }
        }
    }
}