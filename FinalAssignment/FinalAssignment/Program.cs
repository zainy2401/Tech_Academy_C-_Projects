using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace FinalAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool status = true; //Boolean variable to keep the programming running until value is changed
            Console.WriteLine("Hello! Welcome to the student database, what would you like to do?");
            Console.WriteLine("1. Enter a student into the database. \n2. Display the current student database. \n3. Exit");
            //Begins while loop until the status is changed by users input of exiting the program.
            while (status)
            {
                Console.WriteLine("Enter a number option: ");
                string input = Console.ReadLine(); //Reads an option from the user to determine which action to proceed with in the switch statement
                int number; //Empty int variable to verify input option is actually of integer data type
                //While loop to verify the input option is actually of data type integer and within the bound of options
                while ((!Int32.TryParse(input, out number)) || (number < 1 || number > 3))
                {
                    Console.WriteLine("Please enter a valid option: ");
                    input = Console.ReadLine();
                }
                //Switch statement to consider the value of the input option and execute a block of code depending on the value
                switch (number)
                {
                    //First case statement to add a new student
                    case 1:
                        //Begins new using statement to connect to Student context and thus database in the server.
                        using (var ctx = new StudentContext())
                        {
                            Console.WriteLine("Please enter the student's first name: ");
                            string fname = Console.ReadLine(); //Reads in first name of student
                            Console.WriteLine("Please enter the student's last name : ");
                            string lname = Console.ReadLine(); //Reads in last name of student
                            Console.WriteLine("Please enter the student's age: ");
                            int age = Convert.ToInt32(Console.ReadLine()); //Reads in age of student
                            Console.WriteLine("Please enter the student's address: ");
                            string address = Console.ReadLine(); //Reads in address of student
                            Console.WriteLine("Please enter the student's year: ");
                            int year = Convert.ToInt32(Console.ReadLine()); //Reads in year of student
                            Year example = new Year(); //Creates an empty new "Year" object
                            var query = from b in ctx.Years where b.YearId == year select b; //Query to find the appropriate year values for the one the user has entered
                            //Loops the query to get the only matching record in the Years table
                            foreach(var type  in query)
                            {
                                example = type; //Assigns the empty year the found record
                            }
                            Student student = new Student() { StudentId = 1, FirstName = fname, LastName = lname, Age = age, Address = address, Year = example}; //Creates a new student object to store
                            ctx.Students.Add(student); //Adds the new student to table
                            ctx.SaveChanges(); //Saves changes to the table
                        }
                        break;
                    case 2:
                        //Begins new using statement to connect to Student context and thus database in the server.
                        using (var ctx = new StudentContext())
                        {
                            var query = from b in ctx.Students orderby b.StudentId select b; //Query to select all the records in the students table and order by the student id
                            //Loops through the query and displays the information of selected rows
                            foreach (var e in query)
                            {
                                Console.WriteLine("(First name): " + e.FirstName + " (Last Name): " + e.LastName + " (Age): " + e.Age + " (Address): " + e.Address);
                            }
                        }
                        break;
                    case 3:
                        status = false; //Changes status to exit program
                        break;
                }
            }
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Year Year { get; set; }
    }

    public class Year
    {
        public int YearId { get; set; }
        public string YearGroup { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Year> Years { get; set; }
    }
}
