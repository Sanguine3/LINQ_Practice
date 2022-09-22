using Ex1.Models;

namespace Ex1
{
    internal class Method
    {
        public static void Show()
        {

            var MethodResult = Student.Students
                .Select(x => new
                {
                    x.Id,
                    ClassId = Class.Classes.Select(c => new
                    {
                        c.Id,
                    })
                });

            Console.Write("Result:\n");
            foreach (var item in MethodResult)
            {
                foreach (var item3 in item.ClassId)
                {
                    foreach (var item2 in MethodResult)
                    {
                        Console.WriteLine($"{item2.Id}, {item3.Id}");
                    }
                }
                break;
            }
        }
    }
}