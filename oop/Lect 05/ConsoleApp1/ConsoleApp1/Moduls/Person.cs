using System;

namespace CourseManagementSystem
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public abstract void DisplayInfo();
    }
}
