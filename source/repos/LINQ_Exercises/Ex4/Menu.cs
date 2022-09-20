using Ex1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Menu
    {
        public static void showMenu()
        {

            Console.WriteLine("LINQ Practice - Exercise\n");
            Console.WriteLine("1. Method Syntax");
            Console.WriteLine("2. Query Syntax");
            Console.WriteLine("Numbers that are neither 1 nor 2. Exit");
            Console.WriteLine("\nChoose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());


            while (choice == 1 || choice == 2)
            {
                switch (choice)
                {
                    case 1:
                        Method.Show();
                        Console.WriteLine("\nChoose an option: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Query.Show();
                        Console.WriteLine("\nChoose an option: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
