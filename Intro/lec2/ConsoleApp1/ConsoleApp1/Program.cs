using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your emp id");
            int id =int.Parse(Console.ReadLine());

            Console.WriteLine("enter your emp name");
            String name = Console.ReadLine();

            Console.WriteLine("enter your emp Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your emp salary");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"emp id:{id} name:{name} age:{age} salary:{salary}");
        }
    }
}
