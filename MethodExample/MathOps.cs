using System;

class MathOps
{
    // This method takes two numbers.
    // The second number is optional because it has a default value of 10.
    public int AddNumbers(int a, int b = 10)
    {
        // Add the two numbers together
        int result = a + b;

        // Return the result back to the code that called this method
        return result;
    }
}
