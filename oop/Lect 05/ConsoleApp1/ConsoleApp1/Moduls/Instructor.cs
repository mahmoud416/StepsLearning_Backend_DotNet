using System;

namespace CourseManagementSystem
{
    public class Instructor : Person
    {
        public string AvailableDay { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} | Name: {Name} | Available Day: {AvailableDay} | Salary: {Salary}");
        }
    }
}
