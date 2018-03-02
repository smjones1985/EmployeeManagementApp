using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chapter4Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an Employee class. Items to include as data members are employee number
            // name, date of hire, and monthly salary. 

            //Include appropiate constructors and properties
            //Employee employee = new Employee(42, "Bob", 5000m, string.AddYears(-4));//I've added an example of the call. Visual studio will aid you in generated a matching constructor or you can add it yourself.


            //Just make sure that you accep those parameters and that assign those values to the properties in your class.

            //Override the ToString() method to return all data members.
            // No idea what this means
            //Create a second class to test your Employee
            //How does a 2nd class help with test the Employee class?
            //technically you don't need another class to test employee really, but it would be beneficial to do something with employee at least by creating an object from it and using the .ToString method to validate that it all works
            while (true)
            {
                Console.WriteLine("Please select an option from the menu");
                Console.WriteLine("1. Add new Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. View all Employee");
                Console.WriteLine("4. Modify Employee");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    CreateEmployee();
                }
            }

        }

        private static void CreateEmployee()
        {
            //string test= "";
            Employee CurrentEmployee = new Employee();
            Console.WriteLine("Employee Name: ");
            CurrentEmployee.EmployeeName = Console.ReadLine();



        }
    }

    public class Employee
    {
        public Employee()
        {
        }

        public Employee(int employeeNumber, string name, decimal salary, string dateOfHire)
        {
            EmployeeNumber = employeeNumber;
            EmployeeName = name;
            MonthlySalary = salary;
            DateOfHire = dateOfHire;
        }

        public int EmployeeNumber { get; set; } //remember that this type of variable declaration is just a variable declaration. It is better practice to utitlize properties
        public string EmployeeName { get; set; } //this is a property declaration. You have a bit more control as well in that you could make it so that the variable was readonly or that it can only be set but can't be read
        // Would date of hire be a 'int' or a 'string' -> .Net actually has a data type for dateTime
        public decimal MonthlySalary { get; set; }

        public string DateOfHire { get; set; }
        //provide a constructor for employee that would allow someone to create an employee and be able to pass in the variables at instantiation

        //all classes inherently have a ToString method that can be overridden to say whatever you want. Usually, it will just state the name of the class with its namespace and what not, but we could make it say something more useful
        public override string ToString()
        {
            return string.Format("Employee {0}", EmployeeName);
        }

    }

}