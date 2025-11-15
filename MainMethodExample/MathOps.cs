using System;

public class MathOps
{
    // This method takes an int and adds 10 to it
    public int DoMath(int x)
    {
        // Add 10 to x
        int total = x + 10;

        // Give back the result
        return total;
    }

    // This method works with a decimal and multiplies it by 2
    public int DoMath(decimal y)
    {
        // Multiply the number by 2
        decimal temp = y * 2;

        // Change it to an int and return it
        return (int)temp;
    }

    // This method takes a string, turns it into an int,
    // subtracts 5, and returns the answer
    public int DoMath(string textNum)
    {
        // Turn the string into an int
        int newNum = Convert.ToInt32(textNum);

        // Subtract 5 from it
        int final = newNum - 5;

        // Return the result
        return final;
    }
}
