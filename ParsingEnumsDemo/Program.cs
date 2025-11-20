using System;

namespace DayOfWeekEnumApp
{
    // This enum defines the days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // Read the user's input from the console
            string userInput = Console.ReadLine();

            try
            {
                // Convert the user's input into the DaysOfWeek enum (case-insensitive)
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // Print the successfully parsed day back to the user
                Console.WriteLine("You entered: " + currentDay);
            }
            catch
            {
                // This message is printed if the input cannot be converted into a valid enum value
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console window open so user can see the output
            Console.ReadLine();
        }
    }
}
