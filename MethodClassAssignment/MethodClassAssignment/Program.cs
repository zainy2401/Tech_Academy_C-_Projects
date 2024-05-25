using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operation = new Operations(); //Instantiates (creates an object of the created class "operation")
            operation.addition(5,10); //Passes 2 integers in the method called via the new object created
        }
    }
}
