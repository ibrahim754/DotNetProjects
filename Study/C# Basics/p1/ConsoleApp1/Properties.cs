using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Provide Encapsulation 
    public class Properties
    {
#pragma warning disable CS0414 // The field 'Properties.t' is assigned but its value is never used
        private readonly int t = 0; // can only be modified withthin the constructor
#pragma warning restore CS0414 // The field 'Properties.t' is assigned but its value is never used
        private double _intialCost = 10;
        private double _netCost = 20;
#pragma warning disable CS0414 // The field 'Properties._dis' is assigned but its value is never used
        private double _dis = .20;
#pragma warning restore CS0414 // The field 'Properties._dis' is assigned but its value is never used
#pragma warning disable CS0414 // The field 'Properties._amount' is assigned but its value is never used
        private double _amount = 50;
#pragma warning restore CS0414 // The field 'Properties._amount' is assigned but its value is never used
        private double _readOnlyProp = 50;
        // instead of making a prop that only store the value without any checking, and return the value, we can use automatic prop
        public double Amount { get; set; } 

        // CLR internaly convert any prop onto (setter & getter) accessor Functions ; 
        public double IntialCost
        {
            get
            {
                return _intialCost;
            }
            set
            {
                // prop add more constraint & Validation ^_^
                _intialCost = check(value);
            }
        }
        public double NetCost
        {
            get
            {
                return _netCost;
            }
            // the _netCost, can be only read, can not modfiy it;
            private set 
            {
                // prop add more constraint & Validation ^_^
                _intialCost = check(value);
            }
        }
        public double DisConversionFactor
        { 
            // can not be modfied, within the Class or out ;
            // the difference between it and the NetCost, i can modify the NetCost Within the Class 
            get;
        } = .25;

        public bool isZero => _intialCost == 0; // another prop for checking zero
        private double check(double x) => x >= 0 ? Math.Round(x, 2) : 0;  // Do not repeat your self;
      
        public Properties()
        {
            t = 30; // can be only modified within the Constructor

        }
        // readOnlyProp;
        public double ReadOnlyProp => _readOnlyProp;
        private void test(int x)
        {
            // DisConversionFactor = x; //  =>  error ;
            // NetCost = 20; // => valid Expression;

        }
      
    }
}
