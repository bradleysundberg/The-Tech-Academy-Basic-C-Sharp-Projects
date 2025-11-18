using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the MathOps class
            MathOps ops = new MathOps();

            // Call the method normally, passing in two numbers
            ops.DoMath(10, 5);

            // Call the method again, but specify the parameters by name
            ops.DoMath(firstNumber: 20, secondNumber: 8);

            // Wait for user input so the console window stays open
            Console.ReadLine();
        }
    }
}
