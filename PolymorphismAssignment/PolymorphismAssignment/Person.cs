using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment
{
    //This creates an abstract class for other classes to derive from
    public abstract class Person
    {
        public string firstName { get; set; } //Creates a string property
        public string lastName { get; set; } //Creates a string property

        public abstract void SayName(); //Creates an abstract method that will be defined by a child class
    }
}
