using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start of the program
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.\n");

            // Ask for the student's name
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine();

            // Ask what course the student is on
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();

            // Ask for the current page number and convert the input to an integer
            Console.Write("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask if the student needs help (true or false)
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask about any positive experiences
            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperience = Console.ReadLine();

            // Ask for any additional feedback
            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string feedback = Console.ReadLine();

            // Ask how many hours the student studied and convert to a double (for decimals)
            Console.Write("How many hours did you study today? ");
            double studyHours = Convert.ToDouble(Console.ReadLine());

            // Closing message
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // Keeps the console open until the user presses Enter
            Console.ReadLine();
        }
    }
}
