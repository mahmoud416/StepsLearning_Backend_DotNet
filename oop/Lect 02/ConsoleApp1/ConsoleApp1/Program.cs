using System;

internal class Program
{
    
    class Student
    {
        //  (Properties)
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        // Constructor 
        public Student()
        {
            Id = 0;
            Name = "Unknown";
            Age = 18;
            Address = "Not provided";
        }

        // Constructor (Parameterized)
        public Student(int id, string name, int age, string address)
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;
        }

       
        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {Id}, Name: {Name}, Age: {Age}");
        }

      
        public void DisplayAddress()
        {
            Console.WriteLine($"Address: {Address}");
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== Welcome to Student Management System ===\n");

        Console.Write("How many students you want to add? ");
        int count = int.Parse(Console.ReadLine());

        
        Student[] students = new Student[count];

      
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nEnter information for student #{i + 1}");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Address: ");
            string address = Console.ReadLine();

            
            students[i] = new Student(id, name, age, address);
        }

        
        Console.WriteLine("\n=== Displaying All Students Info ===");
        for (int i = 0; i < count; i++)
        {
            students[i].DisplayInfo();
            students[i].DisplayAddress();
            Console.WriteLine("----------------------------");
        }

        Console.WriteLine("\nProgram Finished. Press any key to exit...");
        Console.ReadKey();
    }
}
