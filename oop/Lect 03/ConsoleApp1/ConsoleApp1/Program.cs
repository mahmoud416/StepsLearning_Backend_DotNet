using System;

namespace TrackCourseApp
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }

        public void DisplayCourse()
        {
            Console.WriteLine($"  Id: {Id}, Name: {Name}, Hours: {Hours}");
        }
    }

    class Track
    {
        public string Name { get; set; }
        public int TotalHours { get; set; }
        public int Capacity { get; set; }
        public Course[] Courses;

        public void DisplayTrack()
        {
            Console.WriteLine("\n=== Track Information ===");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Total Hours: {TotalHours}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine("Courses:");

            for (int i = 0; i < Courses.Length; i++)
            {
                Courses[i].DisplayCourse();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Track track = new Track();

            Console.Write("Enter Track Name: ");
            track.Name = Console.ReadLine();

            Console.Write("Enter Track Total Hours: ");
            track.TotalHours = int.Parse(Console.ReadLine());

            Console.Write("Enter Track Capacity: ");
            track.Capacity = int.Parse(Console.ReadLine());

            Console.Write("Enter number of Courses in this Track: ");
            int courseCount = int.Parse(Console.ReadLine());

            track.Courses = new Course[courseCount];

            for (int i = 0; i < courseCount; i++)
            {
                Console.WriteLine($"\n--- Course {i + 1} ---");
                Course course = new Course();

                Console.Write("Enter Course Id: ");
                course.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Course Name: ");
                course.Name = Console.ReadLine();

                Console.Write("Enter Course Hours: ");
                course.Hours = int.Parse(Console.ReadLine());

                track.Courses[i] = course;
            }

            track.DisplayTrack();
        }
    }
}
