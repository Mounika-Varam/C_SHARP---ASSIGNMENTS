using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    /// <summary>
    /// Represents the details of MarketingExecutive employee.
    /// </summary>
    /// <inheritdoc/>
    public class MarketingExecutive : Employee
    {
        private double _kiloMeterTravel;
        private double _tourAllowances;
        private int _telephoneAllowance;
        private double _grossSalary;


        double KiloMeterTravel
        {
            get { return _kiloMeterTravel; }
            set { _kiloMeterTravel = value; }
        }

        double TourAllowances
        {
            get
            {
                return _tourAllowances;
            }
            set { _tourAllowances = KiloMeterTravel * 5; }
        }

        int TelephoneAllowance
        {
            get { return _telephoneAllowance; }
            set { _telephoneAllowance = 1000; }
        }

        public new double GrossSalary
        {
            set
            {
                _grossSalary = value;
            }
            get
            {
                GrossSalary = Salary + Hra + Ta + Da + KiloMeterTravel + TourAllowances + TelephoneAllowance;
                return _grossSalary;
            }
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
        }

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
            Console.WriteLine("Kilometer Travel: " + KiloMeterTravel);
            Console.WriteLine("Tour Allowance: " + TourAllowances);
            Console.WriteLine("Telephone Allowance: " + TelephoneAllowance);
        }
    }
}
