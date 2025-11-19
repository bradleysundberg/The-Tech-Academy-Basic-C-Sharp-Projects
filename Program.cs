using System;

namespace DivisionApp
{
    class Program
    {
        static void Main(string[] args) // Entry point of the application
        {
            Console.WriteLine("=== Division Program ==="); // Displays a title

            MathOps mathOps = new MathOps(); // Creates an object of MathOps so we can use its methods

            Console.Write("Enter a number: "); // Asks the user to type a number
            string userInput = Console.ReadLine(); // Reads the user's input as a string

            int number = Convert.ToInt32(userInput); // Converts the string input into an integer

            mathOps.DivideByTwo(number); // Calls the method that divides the number by two and prints the result

            Console.WriteLine(); // Prints a blank line

            int doubled; // Will hold the doubled version of the number
            int tripled; // Will hold the tripled version of the number

            mathOps.OutputExample(number, out doubled, out tripled); // Calls a method that uses output parameters

            Console.WriteLine("Doubled: " + doubled); // Displays doubled number
            Console.WriteLine("Tripled: " + tripled); // Displays tripled number

            Console.WriteLine(); // Prints a blank line

            int multiplyOne = mathOps.Multiply(number); // Calls first Multiply method (overload)
            int multiplyTwo = mathOps.Multiply(number, 5); // Calls second Multiply method (overload)

            Console.WriteLine("Multiply (x2): " + multiplyOne); // Shows result of first overload
            Console.WriteLine("Multiply (x5): " + multiplyTwo); // Shows result of second overload

            Console.WriteLine(); // Prints a blank line

            int staticResult = StaticMath.AddTen(number); // Calls a method from the static class

            Console.WriteLine("Static class result (number + 10): " + staticResult); // Displays result of static method

            Console.WriteLine("\nPress any key to exit."); // Asks the user to press a key to close the program
            Console.ReadKey(); // Waits for a key press so the window stays open
        }
    }
}
