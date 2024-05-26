using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment
{
    public class Employee : Person, IQuittable
    {
        public int Id; //Creates an integer property

        //Creates a method that is overriden from the parent class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); //Outputs the first name and last name properties, defined in the parent class
        }
        
        //Defines the quit method that is created in the IQuittable interface
        public void Quit()
        {
            Console.WriteLine(firstName + " has quit!"); //Outputs a message to the console.
        }
    }
}
