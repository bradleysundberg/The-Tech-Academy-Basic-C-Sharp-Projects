using System;

namespace ConstructorChainingDemo
{
    // This class demonstrates constructor chaining
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // First constructor that accepts only a name
        // Sets default age and forwards to the second constructor
        public Person(string name) : this(name, 18)

        // Second constructor that accepts both name and age
        public Person(string name, int age)
        {
            Name = name;  // Assign the Name property
            Age = age;    // Assign the Age property
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const string greeting = "Welcome to the Constructor Demo!";
            // Creates a constant variable that cannot be changed

            Console.WriteLine(greeting);
            // Prints the constant value to the console

            var message = "This variable was declared using 'var'.";
            // Creates a variable using the 'var' keyword (type inferred as string)

            Console.WriteLine(message);
            // Prints the message to the console

            Person person1 = new Person("Alice");
            // Creates a Person object using the constructor that takes one parameter
            // This triggers constructor chaining to the second constructor

            Person person2 = new Person("Bob", 25);
            // Creates a Person object using the constructor that takes two parameters

            Console.WriteLine($"Person 1: {person1.Name}, Age {person1.Age}");
            // Prints the first person's details

            Console.WriteLine($"Person 2: {person2.Name}, Age {person2.Age}");
            // Prints the second person's details
        }
    }
}
