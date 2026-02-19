using System;
using System.Linq;
using CourseManagementSystem.Models;

namespace CourseManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Small School System Demo ===\n");

            #region Students Array
            Student[] students = new Student[0];

            var s1 = new Student(name: "Ali", age: 15, grade: 2);
            s1.AddMarks(80, 90, 75);

            var s2 = new Student("Sara", grade: 2);
            s2.AddMarks(85, 95);

            var s3 = new Student("Omar", age: 16, grade: 3);
            s3.AddMarks(60, 70, 65, 90);

            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = s1;

            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = s2;

            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = s3;

            var combined = s1 + s2;

            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = combined;

            var s4 = new Student("Ali", age: 15, grade: 2);
            Console.WriteLine($"s1 == s4 ? {(s1 == s4)}");
            Console.WriteLine($"s1.Equals(s4) ? {s1.Equals(s4)}");

            Console.WriteLine();
            #endregion

            #region Employees Array
            Employee[] employees = new Employee[0];

            var e1 = new Employee(1, 2000m);
            var e2 = new Employee(2, 2500m);
            var e3 = new Employee(3, 2000m);

            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = e1;

            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = e2;

            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = e3;

            Console.WriteLine($"e1 == e3 ? {(e1 == e3)}");
            Console.WriteLine($"e1 != e2 ? {(e1 != e2)}");
            Console.WriteLine($"e1 < e2 ? {(e1 < e2)}");
            Console.WriteLine($"e2 > e3 ? {(e2 > e3)}");

            Console.WriteLine();
            #endregion

            #region is / as
            object obj = s1;

            if (obj is Student st)
            {
                Console.WriteLine($"{st.Name}, Marks: {st.MarksSummary()}");
            }

            var maybe = obj as Student;
            if (maybe != null)
            {
                Console.WriteLine("cast succeeded using 'as'");
            }

            Console.WriteLine();
            #endregion

            #region Print Students
            Console.WriteLine("---- Students ----");
            for (int i = 0; i < students.Length; i++)
            {
                var st2 = students[i];
                Console.WriteLine($"[{i}] {st2}");
                Console.WriteLine("Marks: " + st2.MarksSummary());
                Console.WriteLine();
            }
            #endregion

            #region Print Employees
            Console.WriteLine("---- Employees ----");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"[{i}] {employees[i]}");
            }
            #endregion

            #region GetType Demo
            Console.WriteLine("\nDemonstrate GetType():");
            Console.WriteLine($"s1.GetType() => {s1.GetType().FullName}");
            Console.WriteLine($"e1.GetType() => {e1.GetType().FullName}");
            #endregion

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
