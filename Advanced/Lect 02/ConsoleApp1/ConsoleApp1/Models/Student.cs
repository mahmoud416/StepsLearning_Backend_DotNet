using System;

namespace CourseManagementSystem.Models
{
    public class Student : Person
    {
        public int Grade { get; set; } = 1;
        public int[] Marks { get; private set; } = new int[0];

        public Student(string name, int age = 0, int grade = 1)
            : base(name, age)
        {
            Grade = grade;
        }

        public void AddMarks(params int[] marks)
        {
            if (marks == null || marks.Length == 0) return;

            // Create a new array and copy existing marks, then append new marks
            int oldLen = Marks.Length;
            int newLen = oldLen + marks.Length;
            int[] newMarks = new int[newLen];

            if (oldLen > 0)
            {
                Array.Copy(Marks, 0, newMarks, 0, oldLen);
            }

            for (int i = 0; i < marks.Length; i++)
            {
                newMarks[oldLen + i] = marks[i];
            }

            // Assign the new array to the property (private set allows this inside class)
            Marks = newMarks;
        }

        public static Student operator +(Student a, Student b)
        {
            if (a is null && b is null) return null;
            if (a is null) return CloneWithName(b, b.Name);
            if (b is null) return CloneWithName(a, a.Name);

            string newName = $"{a.Name}+{b.Name}";
            int newAge = Math.Max(a.Age, b.Age);
            int newGrade = Math.Min(a.Grade, b.Grade);

            Student combined = new Student(newName, newAge, newGrade);

            int[] combinedMarks = new int[a.Marks.Length + b.Marks.Length];
            Array.Copy(a.Marks, 0, combinedMarks, 0, a.Marks.Length);
            Array.Copy(b.Marks, 0, combinedMarks, a.Marks.Length, b.Marks.Length);

            combined.Marks = combinedMarks;
            return combined;
        }

        private static Student CloneWithName(Student src, string name)
        {
            if (src == null) return null;
            Student s = new Student(name, src.Age, src.Grade);
            s.Marks = (int[])src.Marks.Clone();
            return s;
        }

        public static bool operator ==(Student left, Student right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return string.Equals(left.Name, right.Name, StringComparison.OrdinalIgnoreCase)
                && left.Grade == right.Grade;
        }

        public static bool operator !=(Student left, Student right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is Student other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int h = (Name?.ToLowerInvariant().GetHashCode() ?? 0);
            h = (h * 397) ^ Grade.GetHashCode();
            return h;
        }

        public override string GetRoleDescription()
        {
            return $"Student (Grade {Grade})";
        }

        public string MarksSummary()
        {
            if (Marks == null || Marks.Length == 0) return "No marks";
            return string.Join(", ", Marks);
        }
    }
}
