using System;
using System.Collections.Generic;

// Defines the Employee class with Id, FirstName, and LastName properties
public class Employee
{
    // Stores the employee's Id
    public int Id { get; set; }

    // Stores the employee's first name
    public string FirstName { get; set; }

    // Stores the employee's last name
    public string LastName { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Creates a list of Employee objects
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Joe", LastName = "Johnson" },
            new Employee { Id = 3, FirstName = "Mary", LastName = "White" },
            new Employee { Id = 4, FirstName = "Sam", LastName = "Brown" },
            new Employee { Id = 5, FirstName = "Chris", LastName = "Black" },
            new Employee { Id = 6, FirstName = "Anna", LastName = "Davis" },
            new Employee { Id = 7, FirstName = "Paul", LastName = "Wilson" },
            new Employee { Id = 8, FirstName = "Kate", LastName = "Moore" },
            new Employee { Id = 9, FirstName = "John", LastName = "Taylor" },
            new Employee { Id = 10, FirstName = "Emily", LastName = "Clark" }
        };

        // Creates a list to store employees with the first name "Joe" using a foreach loop
        List<Employee> joesForeach = new List<Employee>();

        // Loops through each employee in the list
        foreach (Employee emp in employees)
        {
            // Checks if the employee's FirstName property matches "Joe"
            if (emp.FirstName == "Joe")
            {
                // Adds the employee to the new list
                joesForeach.Add(emp);
            }
        }

        // Creates a list of employees named "Joe" using a lambda expression
        List<Employee> joesLambda = employees.FindAll(e => e.FirstName == "Joe");

        // Creates a list of employees whose Id is greater than 5 using a lambda expression
        List<Employee> idGreaterThanFive = employees.FindAll(e => e.Id > 5);

        // Outputs the results to the console
        Console.WriteLine("Employees named Joe (foreach):");
        foreach (var joe in joesForeach)
        {
            Console.WriteLine($"{joe.Id} - {joe.FirstName} {joe.LastName}");
        }

        Console.WriteLine();

        Console.WriteLine("Employees named Joe (lambda):");
        foreach (var joe in joesLambda)
        {
            Console.WriteLine($"{joe.Id} - {joe.FirstName} {joe.LastName}");
        }

        Console.WriteLine();

        Console.WriteLine("Employees with Id > 5:");
        foreach (var emp in idGreaterThanFive)
        {
            Console.WriteLine($"{emp.Id} - {emp.FirstName} {emp.LastName}");
        }
    }
}
