using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public const int MinumumLoggedHours = 176;
        public const double OverTimeRate = 1.25;
        public int AdditionalHours { get { return AdditionalHours; } private set { AdditionalHours = value; } } // update only on the class,
        public int Id { get; set; }
        public string Name { get; set; }
        public double LoggedHours { get; set; }
        public double Wage { get; set; }
        public double OverTimeHours { get; set; }
 
        public bool checkLoggedHours() => (LoggedHours - MinumumLoggedHours) < 0;
        public virtual double BasicSalary()
        {
            if (checkLoggedHours())
            {
 
                return 0;
            }
             return LoggedHours * Wage;
        }
        public virtual double OverTimeSalary()
        {

            if (checkLoggedHours())
            {
                return 0;
            }
            OverTimeHours = LoggedHours - MinumumLoggedHours;     
 
            return  OverTimeHours * 1.25 * Wage;
        }
        public virtual double TotalSalary()
        {
            if (checkLoggedHours())
            {
 
                return 0;
            }
 
            return OverTimeSalary() + BasicSalary();
        }
        public override string ToString()
        {
            return $"\nId: {Id}\nName: {Name}\nLoggedHours: {LoggedHours}\nWage: {Wage}\nBaseSalary: {BasicSalary()}\nOverTime Salary: {OverTimeSalary()}\nTotal Salary:{TotalSalary()}"; 
        }

    }
    public class Manager: Employee
    {
        private const double Allowance = .05;
        public override double TotalSalary()
        {
 

            return base.TotalSalary() * (1.0 + Allowance);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nAllowance Rate : {Allowance}";
        }
    }
    public class Maintanance : Employee
    {
        private const int Hardship = 100;

    }
    public class Sales : Employee
    {
        private double Commission { get; set; }
        private double Bouns { get; set; }

    }
    public class Developer : Employee
    {
        private const double Bouns = 0.03;
        private bool f = false;

    }

}
