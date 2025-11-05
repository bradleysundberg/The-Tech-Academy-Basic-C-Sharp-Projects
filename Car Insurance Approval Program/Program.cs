using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the program title
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            // Ask for the user's age
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if the user has ever had a DUI
            Console.Write("Have you ever had a DUI? (true/false): ");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Ask for the number of speeding tickets the user has
            Console.Write("How many speeding tickets do you have? ");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(); // add a blank line for readability

            // Determine whether the applicant qualifies for car insurance
            // Rules:
            //  - Must be over 15 years old
            //  - Must not have any DUIs
            //  - Must have 3 or fewer speeding tickets
            bool isQualified = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);

            // Display the result
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);

            Console.WriteLine(); // add spacing at the end
            Console.WriteLine("Thank you for applying!");
        }
    }
}
