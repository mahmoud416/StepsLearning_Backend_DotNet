namespace CourseManagementSystem
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int DurationInHours { get; set; }

        public void DisplayInfo()
        {
            System.Console.WriteLine($"ID: {Id} | Title: {Title} | Duration: {DurationInHours} hours");
        }
    }
}
