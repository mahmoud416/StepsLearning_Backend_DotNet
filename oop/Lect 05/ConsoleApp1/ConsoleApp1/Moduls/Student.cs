using System;

namespace CourseManagementSystem
{
    public class Student : Person
    {
        public int Age { get; set; }
        public string AssignedTrack { get; set; } = string.Empty;

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} | Name: {Name} | Age: {Age} | Track: {AssignedTrack}");
        }
    }
}
