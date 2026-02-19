namespace CourseManagementSystem
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Course[] Courses { get; set; } = new Course[0];

        public void DisplayInfo()
        {
            System.Console.WriteLine($"\nTrack: {Name} (ID: {Id})");
            System.Console.WriteLine("Courses in this track:");
            if (Courses.Length == 0)
            {
                System.Console.WriteLine("   No courses in this track.");
            }
            else
            {
                foreach (var course in Courses)
                {
                    System.Console.WriteLine($"   - {course.Title} ({course.DurationInHours} hours)");
                }
            }
        }
    }
}
