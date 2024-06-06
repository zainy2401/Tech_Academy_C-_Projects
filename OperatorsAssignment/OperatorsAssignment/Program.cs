using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee() { Id = 1}; //Creates and initalises object with id of 1
            Employee person2 = new Employee() { Id = 2 }; //Creates and initalises object with id of 2
            Employee person3 = new Employee() { Id = 1}; //Creates and initalises object with id of 1 which is a duplicate of the first object
            Console.WriteLine(person1 == person2); //Compares the first object with second, should output false
            Console.WriteLine();
            Console.WriteLine(person1 == person3); //Compares the first object with third, should output true
        }
    }
}
