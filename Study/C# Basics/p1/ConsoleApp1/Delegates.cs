using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Emp
    {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public float TotalSales { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Gender { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
    class Report
    {
        public delegate  bool IllegableEmps (Emp emp);
        private static  void WellEmps(Emp[] emps, string output, IllegableEmps illegableEmps) 
        {
            Console.WriteLine(output);

            foreach (Emp emp in emps)
            {
                if (illegableEmps(emp))
                {
                    string outt = $"Id = {emp.Id} | Name =  {emp.Name} | TotalSales = {emp.TotalSales} |  Gender = {emp.Gender}";
                    Console.WriteLine(outt);
                }
            }
            Console.WriteLine("\n\n");
        }
        public  static void ReportDetials(Emp[] emps ,int operationType)
        {
            // With Lamada Expreesion => 

            WellEmps(emps, "Employees with Sales 60000+", e => e.TotalSales >= 60000f);

            // With Anonymous Delegate 

            WellEmps(emps, "Emplotees with Sales Between 20000 and 13000", delegate (Emp e) { return e.TotalSales >= 20000f && e.TotalSales <= 13000f;}) ;
        

        }

    }
    public class Rectangle
    {
        // define Mutli TaskDelegte
        private double _width, _height;
        public Rectangle(double width, double height)
        {
            this._width = width;
            this._height = height;
        }
        public Rectangle()
        {
            _width = 0;
            _height = 0;
        }
        public double Width
        {
            get { return _width; }
            set { _width = Math.Max(0, value); }
        }
        public Double Height
        {
            get { return _height; }
            set { _height = Math.Max(0, value); }
        }
        public double GetArea() =>   _width * _height;
        public double GetParameter ()=> 2 * (_width + _height);


        
    }
}
