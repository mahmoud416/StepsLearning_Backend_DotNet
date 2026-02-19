using System;

namespace StudentApp
{
    // ===== Part 2 & 3:  Student =====
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }    
        public double Grade { get; set; }  
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Part 1 =====
            Console.Write("Enter your grade (0-100): ");
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 50)
                Console.WriteLine("You passed!");
            else
                Console.WriteLine("You failed!");

            Console.WriteLine("\n=============================\n");

            // ===== Part 2 =====
            Student s1 = new Student();

            Console.Write("Enter student name: ");
            s1.Name = Console.ReadLine();

            Console.Write("Enter student age: ");
            s1.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter student grade: ");
            s1.Grade = double.Parse(Console.ReadLine());

            Console.WriteLine("\n=== Student Information ===");
            Console.WriteLine($"Name: {s1.Name}");
            Console.WriteLine($"Age: {s1.Age}");
            Console.WriteLine($"Grade: {s1.Grade}");

            Console.WriteLine("\n=============================\n");

            // ===== Part 3 =====
            Student s2 = new Student();

            Console.Write("Enter student's name: ");
            s2.Name = Console.ReadLine();

            Console.Write("Enter student's mark: ");
            s2.Grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nName: {s2.Name}");
            Console.WriteLine($"Mark: {s2.Grade}");

            if (s2.Grade >= 50)
                Console.WriteLine("Passed");
            else
                Console.WriteLine("Failed");
        }
    }
}
