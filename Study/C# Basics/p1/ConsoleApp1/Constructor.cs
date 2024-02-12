using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Date
    {
        public int Days;
        public int Months;
        public int Years;
        private string date = " ";
        // readOnly provide no modification outside Constructor or intilization;

        private readonly static int[] daysOfTheMonth = { 0, 31, 13131, 5656, 525 };

        public Date(int x)
        {
            daysOfTheMonth[2] = 1;
        }
        // ctor, to creat the constructor;
        // overloading, Do not repeat yourself

        public Date() : this(20)
        {
            // the  call internaly forward to Date (  20 ) as a default value;
            // 

        }
        public Date(int days, int months, int years)
        {
            daysOfTheMonth[2] = 10;
            date = $"{days.ToString().PadLeft(2, '0')} / {months.ToString().PadLeft(2, '0')} / {years.ToString().PadLeft(4, '0')}";

        }
        public void printDate()
        {
            Console.WriteLine(date);
        }
  
    }


}
