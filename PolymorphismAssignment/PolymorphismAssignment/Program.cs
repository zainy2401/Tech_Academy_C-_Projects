using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee() { Id = 1, firstName = "Zain", lastName = "Aziz" }; //This instantiates an object of the employee class, defines the data in the curly braces
            person.SayName(); //Calls the say name method on the person object
            person.Quit(); //Calls the quit method on the person object
        }
    }
}
