using System;

namespace CourseManagementSystem.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected Person(string name, int age = 0)
        {
            Name = name ?? string.Empty;
            Age = age;
        }

        public override string ToString()
        {
            return $"{GetRoleDescription()} | Name: {Name} | Age: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return this.GetType() == other.GetType()
                    && string.Equals(this.Name, other.Name, StringComparison.OrdinalIgnoreCase)
                    && this.Age == other.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int h = GetType().GetHashCode();
            h = (h * 397) ^ (Name?.ToLowerInvariant().GetHashCode() ?? 0);
            h = (h * 397) ^ Age.GetHashCode();
            return h;
        }

        public abstract string GetRoleDescription();
    }
}
