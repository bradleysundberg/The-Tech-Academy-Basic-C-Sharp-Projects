using System;
using System.Text; // lets us use StringBuilder

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Concatenate three strings ---
            // make three string variables
            string first = "John";
            string middle = "A.";
            string last = "Smith";

            // join them together into one full name
            string fullName = first + " " + middle + " " + last;

            // print out the result
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine(); // just makes a blank line

            // --- Convert a string to uppercase ---
            // make the name all uppercase letters
            string upperName = fullName.ToUpper();

            // show the uppercase version
            Console.WriteLine("Uppercase Name: " + upperName);
            Console.WriteLine();

            // --- Use a StringBuilder to make a paragraph ---
            // create a StringBuilder object
            StringBuilder sb = new StringBuilder();

            // add sentences one at a time
            sb.Append("This is the first sentence. ");
            sb.Append("Here is another sentence that adds more info. ");
            sb.Append("Finally, this is the last sentence of the paragraph.");

            // print out the finished paragraph
            Console.WriteLine("Paragraph built with StringBuilder:");
            Console.WriteLine(sb.ToString());

            // pause the program so it doesn’t close right away
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
