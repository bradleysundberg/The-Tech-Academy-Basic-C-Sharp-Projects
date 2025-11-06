using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            // Convert the user input from string to a decimal number
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package weight exceeds 50
            if (weight > 50)
            {
                // Display error message and exit program if package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // Prompt the user to enter the package width
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user to enter the package height
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user to enter the package length
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if the sum of dimensions exceeds 50
            if ((width + height + length) > 50)
            {
                // Display error message and exit program if package is too big
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Calculate the shipping quote
            // Multiply dimensions together, then multiply by weight, then divide by 100
            decimal quote = (width * height * length * weight) / 100;

            // Display the shipping quote formatted as currency
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");

            // Thank the user
            Console.WriteLine("Thank you!");
        }
    }
}
