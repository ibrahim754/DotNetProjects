using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        // CLR have a garbage collector, which remove the unused objects from memory;
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Person()
        {
            //Console.WriteLine("This is the Constructor");
           
        }
        public static void MakeSomeGarabge (int n)
        {
            Person p;
            for(int i = 0; i < n; i++)
            {
                p = new Person();

            }  
        }
        public static void CleanGC()
        {
            var numOfObjectsInMemoryBeforeCleaning = GC.GetTotalMemory(false);
            GC.Collect();
            var numOfObjectsInMemomryAfterCleaning = GC.GetTotalMemory(true);
            Console.WriteLine($"numOfObjectsInMemoryBeforeCleaning = {numOfObjectsInMemoryBeforeCleaning} \nnumOfObjectsInMemomryAfterCleaning = {numOfObjectsInMemomryAfterCleaning} ");
        }

    }
}
