using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CollectionFramework
{
    internal class ListEmployeeManagement
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> { };
            int empNo = 0;
            string empName = "";
            double salary = 0;
            int choice = 0;

            Console.WriteLine("--------EMPLOYEE REGISTRATION--------");

            while (choice != 4)
            {
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Display Employee List");
                Console.WriteLine("3.Total Number of Employees");
                Console.WriteLine("4.Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.Write("Enter Employee Number: ");
                            empNo = int.Parse(Console.ReadLine());

                            Console.Write("Enter Employee Name: ");
                            empName = Console.ReadLine();
                            try
                            {
                                Console.Write("Enter Employee Salary: ");
                                salary = double.Parse(Console.ReadLine());
                                employees.Add(new Employee() { EmpNo = empNo, EmpName = empName, Salary = salary });

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
                        break;

                    case 2:
                        foreach (Employee emp in employees)
                        {
                            Console.WriteLine(emp.EmpName);
                        }
                        break;

                    case 3:
                        Console.WriteLine(employees.Count());
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Enter Correct Choice");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
