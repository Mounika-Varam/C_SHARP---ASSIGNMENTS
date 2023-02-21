using System;

namespace DelegateEx
{
    public delegate void EmployeeDelegate();
    internal class EmployeeManagement
    {
        static void Main(string[] args)
        {
            // Creating instance of employee class 
            Manager manager = new();
            MarketingExecutive marketingExecutive = new();
            

            Console.WriteLine("--------EMPLOYEE REGISTRATION--------");

            Console.WriteLine("\n--------Manager-------\n");
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

            Console.WriteLine("\n---------Marketing Executive---------\n");

            try
            {
                Console.Write("Enter Employee Number: ");
                marketingExecutive.EmpNo = int.Parse(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                marketingExecutive.EmpName = Console.ReadLine();
                try
                {
                    Console.Write("Enter Employee Salary: ");
                    marketingExecutive.Salary = double.Parse(Console.ReadLine());

                    marketingExecutive.CalculateSalary();
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

            Console.WriteLine("\n-------------EMPLOYEE DETAILS--------------\n");
            EmployeeDelegate empDel = new EmployeeDelegate(manager.PrintDetails);
            empDel += marketingExecutive.PrintDetails;

            empDel.Invoke();
        }
    }
}
