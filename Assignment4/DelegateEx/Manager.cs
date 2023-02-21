using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    public class Manager : Employee
    {
        private double _petrolAllowance;
        private double _foodAllowance;
        private double _otherAllowances;
        private double _grossSalary;

        double PetrolAllowance
        {
            get
            {
                PetrolAllowance = 0.08 * Salary;
                return _petrolAllowance;
            }
            set { _petrolAllowance = value; }
        }

        double FoodAllowance
        {
            get
            {
                FoodAllowance = 0.13 * Salary;
                return _foodAllowance;
            }
            set { _foodAllowance = value; }
        }

        double OtherAllowances
        {
            get
            {
                OtherAllowances = 0.03 * Salary;
                return _otherAllowances;
            }
            set { _otherAllowances = value; }
        }

        public new double GrossSalary
        {
            set { _grossSalary = value; }
            get
            {
                GrossSalary = Salary + Hra + Ta + Da + PetrolAllowance + FoodAllowance + OtherAllowances;

                return _grossSalary;
            }
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
        }

        /// <summary>
        /// Prints the details of Manager employee.
        /// </summary>
        public void PrintDetails()
        {
            Console.WriteLine("---Employee Details----");
            Console.WriteLine("Employee Id: " + EmpNo);
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine("Employee Salary: " + Salary);
            Console.WriteLine("HRA: " + Hra);
            Console.WriteLine("TA: " + Ta);
            Console.WriteLine("DA: " + Da);
            Console.WriteLine("PF: " + Pf);
            Console.WriteLine("TDS: " + Tds);
            Console.WriteLine("Net Salary: " + NetSalary);
            Console.WriteLine("Gross Salary: " + GrossSalary);
            Console.WriteLine("Petrol Allowance: " + PetrolAllowance);
            Console.WriteLine("Food Allowance: " + FoodAllowance);
            Console.WriteLine("Other Allowances: " + OtherAllowances);
        }
    }
}
