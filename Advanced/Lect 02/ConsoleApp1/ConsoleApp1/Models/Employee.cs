using System;

namespace CourseManagementSystem.Models
{
    public struct Employee : IEquatable<Employee>, IComparable<Employee>
    {
        public int ID { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, decimal salary)
        {
            ID = id;
            Salary = salary;
        }

        public static bool operator ==(Employee a, Employee b) => a.Salary == b.Salary;
        public static bool operator !=(Employee a, Employee b) => a.Salary != b.Salary;

        public static bool operator <(Employee a, Employee b) => a.Salary < b.Salary;
        public static bool operator >(Employee a, Employee b) => a.Salary > b.Salary;

        public override bool Equals(object obj) =>
            obj is Employee e && Salary == e.Salary;

        public bool Equals(Employee other) => Salary == other.Salary;

        public override int GetHashCode() => Salary.GetHashCode();

        public int CompareTo(Employee other) => Salary.CompareTo(other.Salary);

        public override string ToString()
        {
            return $"Employee ID: {ID} | Salary: {Salary:C}";
        }
    }
}
