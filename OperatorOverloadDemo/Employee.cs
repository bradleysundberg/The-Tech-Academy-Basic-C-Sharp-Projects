using System;

namespace OperatorOverloadDemo
{
    class Employee
    {
        public int Id { get; set; }
        // Stores the employee's unique identifier

        public string FirstName { get; set; }
        // Stores the employee's first name

        public string LastName { get; set; }
        // Stores the employee's last name

        public static bool operator ==(Employee e1, Employee e2)
        {
            if (ReferenceEquals(e1, null) && ReferenceEquals(e2, null)) return true;
            // If both objects are null, they are considered equal

            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null)) return false;
            // If only one object is null, they are not equal

            return e1.Id == e2.Id;
            // Compare Employees based on their Id values
        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2);
            // The != operator is simply the opposite of ==
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
                // Check whether the incoming object is an Employee
                return this.Id == emp.Id;
            // Compare Ids for equality

            return false;
            // If the object is not an Employee, return false
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
            // Return a hash code based on the employee's Id
        }
    }
}
