using System;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boolean Comparison Practice");
            Console.WriteLine();

            // WHILE LOOP example
            int count = 1; // start counting from 1

            // loop runs while count is less than or equal to 5
            while (count <= 5)
            {
                Console.WriteLine("Count is: " + count);
                count++; // add 1 each time
            }

            Console.WriteLine("Done with the while loop!");
            Console.WriteLine();

            // DO-WHILE LOOP example
            int userGuess;

            // this one will always run at least once
            do
            {
                Console.Write("Guess a number between 1 and 3: ");
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess != 2)
                {
                    Console.WriteLine("Nope, try again!");
                }

            } while (userGuess != 2); // keep looping until user enters 2

            Console.WriteLine("You got it!");
        }
    }
}
