using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassAssignment
{
    public class Operations
    {
        //Creates a method that does not have to return a value, but takes in 2 integer variables
        public void addition(int num1, int num2)
        {
            Console.WriteLine(num1 + " + 5 = " + (num1+5)); //Outputs to the console the calculation of the first integer passed added by 5
            Console.WriteLine("The second integer passed is: " + num2); //Outputs to the console the second integer passed
        }
    }
}
