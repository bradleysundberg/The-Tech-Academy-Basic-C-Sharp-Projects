using System;

class Program
{
    static void Main()
    {
        // Make a new object from the MathOps class so we can use its method
        MathOps mathObject = new MathOps();

        // Ask the user for the first number
        Console.WriteLine("Please enter the first number:");

        // Read what the user types (ReadLine might return null, so we add !)
        string firstInput = Console.ReadLine()!;

        // Change the text the user typed into an integer
        int firstNumber = Convert.ToInt32(firstInput);

        // Ask the user for the second number, but tell them it's optional
        Console.WriteLine("Please enter the second number (or press ENTER to skip):");

        // Read the second input (also add ! because it might be null)
        string secondInput = Console.ReadLine()!;

        // This will store the final answer from the method
        int answer;

        // Check if the user skipped the second number
        if (secondInput == "")
        {
            // User skipped, so only give one number to the method
            answer = mathObject.AddNumbers(firstNumber);
        }
        else
        {
            // User did enter a second number, so convert it to an int
            int secondNumber = Convert.ToInt32(secondInput);

            // Call the method with both numbers
            answer = mathObject.AddNumbers(firstNumber, secondNumber);
        }

        // Show the result to the user
        Console.WriteLine("The answer is: " + answer);

        // Pause the program so it does not close right away
        Console.WriteLine("Press any key to close...");
        Console.ReadKey();
    }
}
