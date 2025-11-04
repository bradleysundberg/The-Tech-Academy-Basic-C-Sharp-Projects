using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();

            // Person 1
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate: ");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Hours worked per week: ");
            decimal hoursPerWeek1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            // Person 2
            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate: ");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Hours worked per week: ");
            decimal hoursPerWeek2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            // Annual salary calculation
            decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            Console.WriteLine("Annual salary of Person 1: " + annualSalary1.ToString("C"));
            Console.WriteLine("Annual salary of Person 2: " + annualSalary2.ToString("C"));
            Console.WriteLine();

            bool doesPerson1MakeMore = annualSalary1 > annualSalary2;

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(doesPerson1MakeMore);

            Console.WriteLine();
            Console.WriteLine("Press Enter to close...");
            Console.ReadLine();
        }
    }
}
