using System;

namespace CourseManagementSystem
{
    public class Manager : Person
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} | Name: {Name}");
        }
    }
}
