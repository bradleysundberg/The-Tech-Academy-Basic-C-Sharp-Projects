using System;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] words = { "Hello", "Welcome", "Goodbye", "Thanks" };

        // Ask the user to input some text
        Console.WriteLine("Please enter some text to add to each word:");
        string userInput = Console.ReadLine();

        // Loop through each element in the array and add the user's input
        for (int i = 0; i < words.Length; i++)
        {
            // Append the user's text to each string in the array
            words[i] = words[i] + " " + userInput;
        }

        // Create a second loop that prints each string in the array
        Console.WriteLine("\nHere are the updated strings:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Keep the console window open until the user presses a key
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
