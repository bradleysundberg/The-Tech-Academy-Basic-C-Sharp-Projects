using System;

namespace ConsoleApp
{
    // Abstract class 'Person' cannot be instantiated directly
    // It serves as a base class for other classes like 'Employee'
    public abstract class Person
    {
        // Property to store the first name
        public string FirstName { get; set; }

        // Property to store the last name
        public string LastName { get; set; }

        // Abstract method 'SayName' must be implemented by derived classes
        public abstract void SayName();
    }

    // 'Employee' class inherits from 'Person'
    // This means it gets FirstName, LastName properties, and must implement SayName()
    public class Employee : Person
    {
        // Override the abstract SayName() method from the Person class
        public override void SayName()
        {
            // Output the full name to the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            Employee employee = new Employee();

            // Assign values to the FirstName and LastName properties
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call the SayName() method, which prints the full name
            employee.SayName();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
