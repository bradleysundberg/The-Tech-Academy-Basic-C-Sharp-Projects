using System;

namespace ConsoleApp
{
    // Define a base class called Person
    public class Person
    {
        // Property to store the first name of the person
        public string FirstName { get; set; }

        // Property to store the last name of the person
        public string LastName { get; set; }

        // Void method that prints the full name to the console
        public void SayName()
        {
            // Write the person's full name in the format "Name: [full name]"
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    // Define a class called Employee that inherits from Person
    public class Employee : Person
    {
        // Property to store the employee's ID
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new Employee object
            Employee emp = new Employee();

            // Set the first name to "Sample"
            emp.FirstName = "Sample";

            // Set the last name to "Student"
            emp.LastName = "Student";

            // Call the SayName() method inherited from Person
            emp.SayName();

            // Wait for user input before closing the console
            Console.ReadLine();
        }
    }
}
