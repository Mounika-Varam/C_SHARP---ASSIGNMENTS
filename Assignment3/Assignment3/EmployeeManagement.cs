using System;
using LitwareLib;


namespace EmployeeManagementSystem
{

    /// <remarks>
    /// Represents a Employee Management console application.
    /// </remarks>
    internal class EmployeeManagement
    {
        static void Main(string[] args)
        {
            // Creating instance of employee class 
            Manager manager = new();
            IPrintable m = new Manager();
            MarketingExecutive marketingExecutive = new();

            Console.WriteLine("--------EMPLOYEE REGISTRATION--------");

            try
            {
                Console.Write("Enter Employee Number: ");
                manager.EmpNo = int.Parse(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                manager.EmpName = Console.ReadLine();
                try
                {
                    Console.Write("Enter Employee Salary: ");
                    manager.Salary = double.Parse(Console.ReadLine());

                    manager.CalculateSalary();
                    manager.PrintDetails();
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Employee salary.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Employee Id.");
            }

        }
    }
}
