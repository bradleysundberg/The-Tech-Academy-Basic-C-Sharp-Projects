using System;
using System.Collections.Generic;

namespace ArrayAndListSelectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- STRING ARRAY -----
            // Make an array of strings
            string[] words = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Ask the user to pick an index
            Console.WriteLine("Pick an index from 0 to 4 for the string array:");
            string stringInput = Console.ReadLine();

            // Turn the user input into a number
            int stringIndex;
            if (int.TryParse(stringInput, out stringIndex))
            {
                // Check if the number is in range
                if (stringIndex >= 0 && stringIndex < words.Length)
                {
                    // Show the word at that index
                    Console.WriteLine("You picked: " + words[stringIndex]);
                }
                else
                {
                    // If the index is too high or low
                    Console.WriteLine("That index doesn’t exist in the array.");
                }
            }
            else
            {
                // If the user didn’t type a number
                Console.WriteLine("Please enter a number next time.");
            }

            Console.WriteLine(); // Makes a blank line for spacing

            // ----- INTEGER ARRAY -----
            // Make an array of numbers
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Ask the user for an index
            Console.WriteLine("Pick an index from 0 to 4 for the number array:");
            string numberInput = Console.ReadLine();

            int numberIndex;
            if (int.TryParse(numberInput, out numberIndex))
            {
                if (numberIndex >= 0 && numberIndex < numbers.Length)
                {
                    Console.WriteLine("You picked: " + numbers[numberIndex]);
                }
                else
                {
                    Console.WriteLine("That index doesn’t exist in the array.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number next time.");
            }

            Console.WriteLine();

            // ----- STRING LIST -----
            // Make a list of colors
            List<string> colors = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };

            // Ask the user for an index from the list
            Console.WriteLine("Pick an index from 0 to 4 for the color list:");
            string listInput = Console.ReadLine();

            int listIndex;
            if (int.TryParse(listInput, out listIndex))
            {
                if (listIndex >= 0 && listIndex < colors.Count)
                {
                    Console.WriteLine("You picked: " + colors[listIndex]);
                }
                else
                {
                    Console.WriteLine("That index doesn’t exist in the list.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number next time.");
            }

            // Pause the program so the user can read the result
            Console.WriteLine("\nPress Enter to close.");
            Console.ReadLine();
        }
    }
}
