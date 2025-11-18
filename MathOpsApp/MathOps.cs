using System; // Needed for Console.WriteLine

namespace ConsoleApp
{
    // This class contains our math-related method
    class MathOps
    {
        // This method takes two integers
        // It performs a math operation on the first number
        // It prints the second number to the screen
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a simple math operation on the first number
            int answer = firstNumber * 2; // Multiply the first number by 2

            // Show the result of the math operation
            Console.WriteLine("The first number doubled is: " + answer);

            // Show the second number on the screen
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }
}
