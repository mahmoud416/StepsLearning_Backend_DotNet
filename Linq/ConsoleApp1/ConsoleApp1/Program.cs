using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class Employee
{
    public string SSN { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public string Location { get; set; }

    public Employee(string ssn, string firstName, string lastName, int age, decimal salary, string location)
    {
        SSN = ssn;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
        Location = location;
    }

    public override string ToString()
    {
        return $"SSN: {SSN}, Name: {FirstName} {LastName}, Age: {Age}, Salary: {Salary:C}, Location: {Location}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("123-45-6789", "John", "Doe", 30, 60000.50m, "New York"),
            new Employee("987-65-4321", "Jane", "Smith", 28, 70000.75m, "Los Angeles"),
            new Employee("456-78-9012", "Jim", "Brown", 45, 80000.00m, "Chicago"),
            new Employee("654-32-1987", "Jack", "Davis", 32, 50000.25m, "Houston"),
            new Employee("321-54-9876", "Jill", "Wilson", 36, 95000.00m, "Phoenix"),
            new Employee("789-01-2345", "Joe", "Taylor", 50, 120000.00m, "Philadelphia"),
            new Employee("234-56-7890", "Jerry", "Anderson", 42, 65000.00m, "San Antonio"),
            new Employee("876-54-3210", "Janet", "Thomas", 29, 85000.00m, "San Diego"),
            new Employee("567-89-0123", "Joy", "Jackson", 39, 70000.00m, "Dallas"),
            new Employee("012-34-5678", "Jess", "White", 33, 75000.00m, "San Jose"),
            new Employee("098-76-5432", "Julia", "Harris", 27, 55000.00m, "Austin"),
            new Employee("678-90-1234", "James", "Martin", 48, 95000.00m, "Fort Worth"),
            new Employee("345-67-8901", "Jordan", "Garcia", 26, 60000.00m, "Columbus"),
            new Employee("876-54-2109", "Jenna", "Martinez", 37, 67000.00m, "Charlotte"),
            new Employee("123-45-0987", "Jacob", "Robinson", 41, 70000.00m, "San Francisco"),
            new Employee("765-43-2109", "Jasmine", "Clark", 35, 82000.00m, "Indianapolis"),
            new Employee("543-21-0987", "Jeff", "Rodriguez", 34, 75000.00m, "Seattle"),
            new Employee("210-98-7654", "Jocelyn", "Lewis", 38, 68000.00m, "Denver"),
            new Employee("432-10-9876", "Jon", "Walker", 31, 72000.00m, "Washington"),
            new Employee("210-98-6543", "Joyce", "Hall", 25, 50000.00m, "Boston")
        };



        // 1. Select all employees

        /*
        var result = employees.Select(s => s);
        var result = employees.ToList();
         */

        // 2. Select employees with age greater than 30

        //var result = employees.Where(e => e.Age > 30);

        // 3. Select employees from "New York"

        //var result = employees.Where(e => e.Location == "New York");

        // 4. Order employees by last name

        //var result = employees.OrderBy(e => e.LastName);

        // 5. Order employees by salary descending

        //var result = employees.OrderByDescending(e => e.Salary);

        // 6. Select only first names of employees

        //var result = employees.Select(e => e.FirstName);

        // 7. Select employees with a salary between 50,000 and 100,000

        //var result = employees.Where(e => e.Salary >= 50000 && e.Salary <= 100000);

        // 8. Group employees by location

        //var result = employees.GroupBy(e => e.Location);

        // 9. Count employees in each location

        //var result = employees.GroupBy(e => e.Location).Select(g => new { location = g.Key, count = g.Count() });

        // 10. Find employee with the highest salary

        //var result = employees.OrderByDescending(e => e.Salary).First();

        // 11. Find employee with the lowest age

        //var result = employees.OrderBy(e => e.Age).First();
        //Console.WriteLine(result);

        //// 12. Select first 5 employees

        //var result = employees.Take(5);

        // 13. Select employees with last name starting with "S"

        //var result = employees.Where(e => e.LastName.StartsWith("S"));

        // 14. Calculate the average salary of employees

        //var result = employees.Average(e => e.Salary);

        // 15. Calculate the sum of all salaries

        //var result = employees.Sum(e => e.Salary);

        // 16. Select employees with unique first names

        //var result = employees
        //    .Select(e => e.FirstName)
        //    .Distinct();

        // 17. Select employees who are 35 years old or older

        //var result = employees.Where(e => e.Age >= 35);

        // 18. Select employees with salary greater than 75,000 and sort them by age

        //var result = employees.Where(e => e.Salary > 75000)
        //                        .OrderBy(g => g.Age);

        // 19. Select employees whose last name contains "son"

        //var result = employees.Where(e => e.LastName.Contains("son"));

        // 20. Select the names of employees who live in "Los Angeles"

        //var result = employees.Where(e => e.Location == "Los Angeles")
        //                        .Select(s => s.FirstName + "" + s.LastName);

        // 21. Count the number of employees aged over 40

        //var result = employees.Count(c => c.Age > 40);

        // 22. Check if any employee has a salary over 100,000

        //var result = employees.Any(e => e.Salary > 100000);

        //var result = employees.Select(e => e.Salary > 100000);

        // 23. Check if all employees are aged over 20

        //var result = employees.All(e => e.Age > 20);

        // 24. Select employees with age as even number

        //var result = employees.Where(e => e.Age % 2 == 0);
        //Console.WriteLine(result);

        // 25. Select employees whose full name contains "John"

        //var result = employees.Where(e => (e.FirstName + " " + e.LastName).Contains("John"));

        // 26. Find the employee with the SSN "123-45-6789"

        //var result = employees.FirstOrDefault(e => e.SSN == "123-45-6789");


        // 27. Select the youngest employee's full name

        //var result = employees
        //               .OrderBy(a => a.Age)
        //               .Select(e => e.FirstName + " " + e.LastName)
        //               .First();

        // 28. Select employees grouped by their age

        //var result = employees.GroupBy(e => e.Age);
        // 29. Select the top 3 highest-paid employees

        //var result = employees
        //            .OrderByDescending(o => o.Salary)
        //            .Take(3);

        // 30. Select employees whose first name length is greater than 4

        //var result = employees.Where(e => e.FirstName.Length > 4);



        //print results
        foreach (var emp in result)
        {
            Console.WriteLine(emp);
        }


    }
}



