using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Arrays
        string[] words = { "Hello", "Welcome", "Goodbye", "Thanks" };

        // List with duplicates
        List<string> fruits = new List<string>() { "Apple", "Banana", "Orange", "Apple", "Grape", "Banana" };

        // List with unique items
        List<string> colors = new List<string>() { "Red", "Blue", "Green", "Yellow", "Purple" };

        // Another list with duplicates (for search exercise)
        List<string> animals = new List<string>() { "Dog", "Cat", "Bird", "Dog", "Fish", "Cat" };

        // List for foreach duplicate check
        List<string> letters = new List<string>() { "A", "B", "C", "D", "C" };

        // Variable to control infinite loop
        bool keepRunning = true;

        // Start infinite loop
        while (keepRunning)
        {
            // User input to append to array 
            Console.WriteLine("\nEnter text to add to each word in the array (or type 'exit' to quit):");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                keepRunning = false;
                Console.WriteLine("Exiting program...");
                break; // Exit the loop
            }

            // Array loop using '<'
            Console.WriteLine("\nLoop using '<' operator:");
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i] + " " + userInput;
                Console.WriteLine(words[i]);
            }

            // Array loop using '<='
            Console.WriteLine("\nLoop using '<=' operator:");
            for (int i = 0; i <= words.Length - 1; i++)
            {
                Console.WriteLine(words[i]);
            }

            // Search duplicate list (fruits)
            Console.WriteLine("\nSearch the list of fruits (duplicates allowed).");
            Console.WriteLine("Enter a fruit name to search for:");
            string fruitInput = Console.ReadLine();

            bool fruitFound = false;
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].ToLower() == fruitInput.ToLower())
                {
                    Console.WriteLine($"Match found! \"{fruits[i]}\" is at index {i}.");
                    fruitFound = true;
                    // No break: find all matches
                }
            }

            if (!fruitFound)
            {
                Console.WriteLine($"Sorry, \"{fruitInput}\" is not on the list.");
            }

            // Search unique list (colors)
            Console.WriteLine("\nSearch the list of colors (unique items).");
            Console.WriteLine("Enter a color name to search for:");
            string colorInput = Console.ReadLine();

            bool colorFound = false;
            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i].ToLower() == colorInput.ToLower())
                {
                    Console.WriteLine($"Match found! \"{colors[i]}\" is at index {i}.");
                    colorFound = true;
                    break; // Stop loop after first match
                }
            }

            if (!colorFound)
            {
                Console.WriteLine($"Sorry, \"{colorInput}\" is not on the list.");
            }

            // Search duplicate list (animals)
            Console.WriteLine("\nSearch the list of animals (duplicates allowed).");
            Console.WriteLine("Enter an animal name to search for:");
            string animalInput = Console.ReadLine();

            bool animalFound = false;
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].ToLower() == animalInput.ToLower())
                {
                    Console.WriteLine($"Match found! \"{animals[i]}\" is at index {i}.");
                    animalFound = true;
                    // No break — show all matches
                }
            }

            if (!animalFound)
            {
                Console.WriteLine($"Sorry, \"{animalInput}\" is not on the list.");
            }

            // Foreach loop to identify duplicates
            Console.WriteLine("\nEvaluating list of letters for duplicates:\n");

            // Create a new list to track seen items
            List<string> seenItems = new List<string>();

            foreach (string letter in letters)
            {
                if (seenItems.Contains(letter))
                {
                    Console.WriteLine($"{letter} - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine($"{letter} - this item is unique");
                    seenItems.Add(letter); // Add to list so it can be tracked later
                }
            }

            Console.WriteLine("\nYou can type more text to repeat or type 'exit' to quit.");
        }

        // End of program
        Console.WriteLine("\nPress any key to close...");
        Console.ReadKey();
    }
}
