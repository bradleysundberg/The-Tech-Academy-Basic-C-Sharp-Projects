using System; // Needed for Console access

namespace DivisionApp // Namespace for this class
{
    class MathOps // Class that holds math-related methods
    {
        public void DivideByTwo(int number) // Method that divides a number by two
        {
            int result = number / 2; // Performs the division
            Console.WriteLine("Half of your number is: " + result); // Prints the result
        }

        public void OutputExample(int number, out int doubled, out int tripled) // Method using output parameters
        {
            doubled = number * 2; // Assigns doubled value to the output variable
            tripled = number * 3; // Assigns tripled value to the output variable
        }

        public int Multiply(int number) // First overloaded method (multiply by 2)
        {
            return number * 2; // Returns the result of the multiplication
        }

        public int Multiply(int number, int factor) // Second overloaded method (multiply by a specific factor)
        {
            return number * factor; // Returns the result using the given factor
        }
    }
}
