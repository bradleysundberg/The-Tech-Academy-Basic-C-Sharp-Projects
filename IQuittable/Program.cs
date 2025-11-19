using System;

// Define an interface called IQuittable
interface IQuittable
{
    // Declare a method signature for Quit
    void Quit();
}

// Define an abstract class Person
abstract class Person
{
    // Property to store first name
    public string FirstName { get; set; }

    // Property to store last name
    public string LastName { get; set; }

    // Abstract method to say the person's name
    public abstract void SayName();
}

// Define Employee class that inherits from Person and implements IQuittable
class Employee : Person, IQuittable
{
    // Implement the abstract SayName method from Person
    public override void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }

    // Implement the Quit method from IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee employee = new Employee();
        employee.FirstName = "Sample";
        employee.LastName = "Student";

        // Call the SayName method from the Employee object
        employee.SayName();

        // Use polymorphism: treat the Employee object as an IQuittable object
        IQuittable quitEmployee = employee;

        // Call the Quit method using the IQuittable reference
        quitEmployee.Quit();

        // Keep the console window open
        Console.ReadLine();
    }
}
