using System;

namespace branching_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below."); // Outputs welcome text
            Console.WriteLine("Please enter the package weight: "); //Output that prompts user to enter package weight
            int weight = Convert.ToInt32(Console.ReadLine()); //Takes the user input and stores it after casting to integer
            //Block of code exits the program if the weight variable is more than 50
            if(weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(0);
            }
            Console.WriteLine("Please enter the package width: "); //Output that prompts user to enter package width
            int width = Convert.ToInt32(Console.ReadLine()); //Takes the user input and stores it after casting to integer
            Console.WriteLine("Please enter the package height: "); //Output that prompts user to enter package height
            int height = Convert.ToInt32(Console.ReadLine()); //Takes the user input and stores it after casting to integer
            Console.WriteLine("Please enter the package length: "); //Output that prompts user to enter package length
            int length = Convert.ToInt32(Console.ReadLine()); //Takes the user input and stores it after casting to integer
            int dimensions = width + height + length; //Takes the 3 user inputs and multiplies it together to get the total dimensions
            //Block of code checks if the dimensions of the package is too big, the program will end, otherwise the it will execute the else block
            if(dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            //This block will execute if the if statement is false
            else
            {
                int quote = (width * height * length * weight) / 100; //Calculates quote
                Console.WriteLine("Your estimated total for shipping this package is: £" + quote + "\nThank You!"); //Outputs final message with the quote.
            }
        }
    }
}
