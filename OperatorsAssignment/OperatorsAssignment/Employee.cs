using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    class Employee
    {
        public int Id { get; set; } //Deinfes an integer variable
        public string FirstName { get; set; } //Defines a string variable
        public string LastName { get; set; } //Defines a string variable

        //This method overloads an the equals operator to compare 2 objects of the Employee class on the basis of the Id property and returns a boolean value along with outputing a message
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if(employee1.Id == employee2.Id)
            {
                Console.WriteLine("The objects match");
            }
            else
            {
                Console.WriteLine("The objects DO NOT match");
            }
            return employee1.Id == employee2.Id;
        }

        //This method does the same as above but instead compares if they are not equal on the basis of the Id property
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("The objects DO NOT match");
            }
            else
            {
                Console.WriteLine("The objects match");
            }
            return employee1.Id != employee2.Id;
        }
    }
}
