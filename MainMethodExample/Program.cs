using System;

class Program
{
    static void Main(string[] args)
    {
        // Make a new MathOps object
        MathOps math = new MathOps();

        // Call the method that uses an int
        int intAnswer = math.DoMath(5);
        // Show the result
        Console.WriteLine("Int result: " + intAnswer);

        // Call the method that uses a decimal
        int decAnswer = math.DoMath(3.5m);
        // Show the result
        Console.WriteLine("Decimal result: " + decAnswer);

        // Call the method that uses a string
        int strAnswer = math.DoMath("10");
        // Show the result
        Console.WriteLine("String result: " + strAnswer);

        // Keep the window open
        Console.ReadLine();
    }
}
