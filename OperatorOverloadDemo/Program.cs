using System;

namespace OperatorOverloadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            // Create first Employee object and assign Id, FirstName, and LastName

            Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };
            // Create second Employee object with the same Id but different names

            bool areEqual = emp1 == emp2;
            // Compare the two Employee objects using the overloaded == operator

            bool areNotEqual = emp1 != emp2;
            // Compare the two Employee objects using the overloaded != operator

            Console.WriteLine("Are the two employees equal? " + areEqual);
            // Display the result of the equality comparison

            Console.WriteLine("Are the two employees NOT equal? " + areNotEqual);
            // Display the result of the inequality comparison

            Console.ReadLine();
            // Pause the console so the output remains visible
        }
    }
}
