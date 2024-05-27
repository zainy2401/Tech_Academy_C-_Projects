using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable person = new Employee() { Id = 1, firstName = "Zain", lastName = "Aziz" }; //Creates an object of IQuittable interface type on the Employee class
            person.Quit(); //Calls the quit method on the person object
        }
    }
}
