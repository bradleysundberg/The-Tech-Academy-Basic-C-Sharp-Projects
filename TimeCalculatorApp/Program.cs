using System;

namespace TimeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            Console.WriteLine("Current date and time: " + DateTime.Now);

            // Ask the user to enter a number
            Console.Write("Enter a number of hours to add: ");

            // Read the user's input as a string
            string input = Console.ReadLine();

            // Convert the user's input from string to integer
            int hoursToAdd;
            if (int.TryParse(input, out hoursToAdd)) // TryParse ensures the input is a valid integer
            {
                // Calculate the future time by adding the entered number of hours to the current time
                DateTime futureTime = DateTime.Now.AddHours(hoursToAdd);

                // Print the calculated future time to the console
                Console.WriteLine("The time in " + hoursToAdd + " hours will be: " + futureTime);
            }
            else
            {
                // Inform the user if the input was not a valid number
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
