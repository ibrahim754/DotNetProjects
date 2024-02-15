using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    /// <summary>
    // set of named constants. Enums are used to define a collection of related values that represent a finite set of possible options or states
    /// </summary>Severity	Code	Description	Project	File	Line	Suppression State
    // static classes cannot have instance constructors     

    public   class TestEnum
    {
        public enum month : long

        {
            Jan = 31,
            Feb = 28,
            Mar = 31,
            Apr = 30,
            May = 31,
            Jun = 30,
            Jul = 31,
            Aug = 31,
            Sep = 30,
            Oct = 31,
            Nov = 30,
            Dec // it takes Nov + 1 , so it becomes 31,
        }
      
     
    }
}
