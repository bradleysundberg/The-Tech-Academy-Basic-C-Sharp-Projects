using System;

class Program
{
    static void Main()
    {
        MathOps mathObject = new MathOps();

        Console.WriteLine("Please enter the first number:");
        string firstInput = Console.ReadLine()!;
        int firstNumber = Convert.ToInt32(firstInput);

        Console.WriteLine("Please enter the second number (or press ENTER to skip):");
        string secondInput = Console.ReadLine()!;

        int answer;

        if (secondInput == "")
        {
            answer = mathObject.AddNumbers(firstNumber);
        }
        else
        {
            int secondNumber = Convert.ToInt32(secondInput);
            answer = mathObject.AddNumbers(firstNumber, secondNumber);
        }

        Console.WriteLine("The answer is: " + answer);
        Console.WriteLine("Press any key to close...");
        Console.ReadKey();
    }
}
