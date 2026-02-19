using System;
using System.Linq;

namespace CourseManagementSystem
{
    class Program
    {
        #region === Arrays (Data Storage) ===
        static Instructor[] instructors = new Instructor[0];
        static Student[] students = new Student[0];
        static Manager[] managers = new Manager[0];
        static Course[] courses = new Course[0];
        static Track[] tracks = new Track[0];
        #endregion

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                ShowMainMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddInstructor(); break;
                    case "2": AddStudent(); break;
                    case "3": AddManager(); break;
                    case "4": AddCourse(); break;
                    case "5": AddTrack(); break;
                    case "6": DisplayAllData(); break;
                    case "7":
                        exit = true;
                        Console.WriteLine("Thank you for using the system. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        #region === Main Menu ===
        static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("===== Course Management System =====");
            Console.WriteLine("1. Add Instructor");
            Console.WriteLine("2. Add Student");
            Console.WriteLine("3. Add Manager");
            Console.WriteLine("4. Add Course");
            Console.WriteLine("5. Add Track");
            Console.WriteLine("6. Display All Data");
            Console.WriteLine("7. Exit");
            Console.Write("Select option: ");
        }
        #endregion

        #region === Add Functions ===

        static void AddInstructor()
        {
            Console.Clear();
            Console.WriteLine("===== Add New Instructor =====");

            Instructor instructor = new Instructor();

            Console.Write("Enter ID: ");
            instructor.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            instructor.Name = Console.ReadLine();

            Console.Write("Enter Available Day: ");
            instructor.AvailableDay = Console.ReadLine();

            Console.Write("Enter Salary: ");
            instructor.Salary = decimal.Parse(Console.ReadLine());

            Array.Resize(ref instructors, instructors.Length + 1);
            instructors[instructors.Length - 1] = instructor;

            Console.WriteLine("✓ Instructor added successfully!");
        }

        static void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("===== Add New Student =====");

            Student student = new Student();

            Console.Write("Enter ID: ");
            student.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            student.Age = int.Parse(Console.ReadLine());

            if (tracks.Length > 0)
            {
                Console.WriteLine("Available Tracks:");
                foreach (var track in tracks)
                {
                    Console.WriteLine($"- {track.Name}");
                }
            }

            Console.Write("Enter Assigned Track: ");
            student.AssignedTrack = Console.ReadLine();

            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;

            Console.WriteLine("✓ Student added successfully!");
        }

        static void AddManager()
        {
            Console.Clear();
            Console.WriteLine("===== Add New Manager =====");

            Manager manager = new Manager();

            Console.Write("Enter ID: ");
            manager.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            manager.Name = Console.ReadLine();

            Array.Resize(ref managers, managers.Length + 1);
            managers[managers.Length - 1] = manager;

            Console.WriteLine("✓ Manager added successfully!");
        }

        static void AddCourse()
        {
            Console.Clear();
            Console.WriteLine("===== Add New Course =====");

            Course course = new Course();

            Console.Write("Enter ID: ");
            course.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Course Title: ");
            course.Title = Console.ReadLine();

            Console.Write("Enter Duration in Hours: ");
            course.DurationInHours = int.Parse(Console.ReadLine());

            Array.Resize(ref courses, courses.Length + 1);
            courses[courses.Length - 1] = course;

            Console.WriteLine("✓ Course added successfully!");
        }

        static void AddTrack()
        {
            Console.Clear();
            Console.WriteLine("===== Add New Track =====");

            Track track = new Track();

            Console.Write("Enter ID: ");
            track.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Track Name: ");
            track.Name = Console.ReadLine();

            if (courses.Length > 0)
            {
                Console.WriteLine("Available Courses:");
                foreach (var course in courses)
                {
                    Console.WriteLine($"{course.Id}. {course.Title} ({course.DurationInHours} hours)");
                }

                Console.WriteLine("Enter course IDs to add (separated by comma):");
                string input = Console.ReadLine();
                string[] courseIds = input.Split(',');

                Course[] tempCourses = new Course[0];

                foreach (string idStr in courseIds)
                {
                    if (int.TryParse(idStr.Trim(), out int courseId))
                    {
                        Course courseToAdd = courses.FirstOrDefault(c => c.Id == courseId);

                        if (courseToAdd != null)
                        {
                            Array.Resize(ref tempCourses, tempCourses.Length + 1);
                            tempCourses[tempCourses.Length - 1] = courseToAdd;
                        }
                    }
                }

                track.Courses = tempCourses;
            }
            else
            {
                Console.WriteLine("No courses available currently.");
            }

            Array.Resize(ref tracks, tracks.Length + 1);
            tracks[tracks.Length - 1] = track;

            Console.WriteLine("✓ Track added successfully!");
        }

        #endregion

        #region === Display All Data ===

        static void DisplayAllData()
        {
            Console.Clear();
            Console.WriteLine("===== Display All Data =====");

            Console.WriteLine("\n----- Instructors -----");
            if (instructors.Length == 0)
                Console.WriteLine("No instructors registered.");
            else
                foreach (var instructor in instructors)
                    instructor.DisplayInfo();


            Console.WriteLine("\n----- Students -----");
            if (students.Length == 0)
                Console.WriteLine("No students registered.");
            else
                foreach (var student in students)
                    student.DisplayInfo();


            Console.WriteLine("\n----- Managers -----");
            if (managers.Length == 0)
                Console.WriteLine("No managers registered.");
            else
                foreach (var manager in managers)
                    manager.DisplayInfo();


            Console.WriteLine("\n----- Courses -----");
            if (courses.Length == 0)
                Console.WriteLine("No courses registered.");
            else
                foreach (var course in courses)
                    course.DisplayInfo();


            Console.WriteLine("\n----- Tracks -----");
            if (tracks.Length == 0)
                Console.WriteLine("No tracks registered.");
            else
                foreach (var track in tracks)
                    track.DisplayInfo();
        }

        #endregion
    }
}
