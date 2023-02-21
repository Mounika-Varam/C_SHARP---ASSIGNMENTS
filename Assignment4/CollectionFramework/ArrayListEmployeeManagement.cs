using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class ArrayListEmployeeManagement
    {
        static void Main(string[] args)
        {
            ArrayList employees = new ArrayList();
            int empNo = 0;
            string empName = "";
            double salary = 0;
            int count = 5;

            Console.WriteLine("--------EMPLOYEE REGISTRATION--------");

            while (count > 0)
            {
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

                employees.Add(new Employee() { EmpNo = empNo, EmpName = empName, Salary = salary });
                count--;
                Console.WriteLine();
            }

            foreach (Employee emp in employees)
            {
                emp.CalculateSalary();
                Console.WriteLine("Employee Number: {0}", emp.EmpNo);
                Console.WriteLine("Employee Name: {0}", emp.EmpName);
                Console.WriteLine("Salary: {0}", emp.Salary);
                Console.WriteLine("HRA: {0}", emp.Hra);
                Console.WriteLine("TA: {0}", emp.Ta);
                Console.WriteLine("DA: {0}", emp.Da);
                Console.WriteLine("PF: {0}", emp.Pf);
                Console.WriteLine("TDS: {0}", emp.Tds);
                Console.WriteLine("Net Salary: {0}", emp.NetSalary);
                Console.WriteLine("Gross Salary: {0}", emp.GrossSalary);
                Console.WriteLine();
            }

        }
    }
}
