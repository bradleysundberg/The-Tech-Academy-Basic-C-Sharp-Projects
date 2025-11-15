using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make an object of the MathStuff class
            MathOps ms = new MathOps();

            // Ask the user for a number
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();

            // Change the user's text into an integer
            int num = Convert.ToInt32(userInput);

            // Call the first method
            int result1 = ms.Add10(num);

            // Call the second method
            int result2 = ms.Times5(num);

            // Call the third method
            int result3 = ms.Square(num);

            // Show the results of all 3 methods
            Console.WriteLine("Your number plus 10 equals: " + result1);
            Console.WriteLine("Your number times 5 equals: " + result2);
            Console.WriteLine("Your number squared equals: " + result3);

            // Wait so program doesn't close right away
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}
