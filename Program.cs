using System;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main()
        {
            using (StudentContext context = new StudentContext())
            {
                context.Database.EnsureCreated();

                Student student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe"
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully.");
            }

            Console.ReadLine();
        }
    }
}
