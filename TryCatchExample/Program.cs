using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of numbers
        List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

        // Ask the user for a number to divide by
        Console.WriteLine("Please enter a number to divide each number in the list by:");

        try
        {
            // Convert the user input to a decimal number
            decimal userNumber = Convert.ToDecimal(Console.ReadLine());

            // Loop through each number in the list
            foreach (int num in numbers)
            {
                // Divide each number by what the user entered and print the result
                decimal answer = num / userNumber;
                Console.WriteLine(num + " divided by " + userNumber + " = " + answer);
            }
        }
        catch (DivideByZeroException ex)
        {
            // This happens if the user tries to divide by 0
            Console.WriteLine("You can't divide by zero!");
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (FormatException ex)
        {
            // This happens if the user types something that isn't a number
            Console.WriteLine("Please type a valid number next time.");
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Catches any other errors
            Console.WriteLine("Something went wrong.");
            Console.WriteLine("Error message: " + ex.Message);
        }
        finally
        {
            // This always runs no matter what
            Console.WriteLine("\nWe are now out of the try/catch block.");
        }

        // This runs after the try/catch
        Console.WriteLine("Program finished. Press any key to close.");
        Console.ReadKey();
    }
}
