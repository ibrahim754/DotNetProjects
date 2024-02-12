using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Methods
    {
        public static int passByRefUsingRef(ref int val)
        {
            // value must be intilized first out of the loop, otherwise you will get error
            val = 40;
            return val;
        }
        public static int passByRefUsingOut(out int val)
        {
            // value must be intilized first inside of the loop, otherwise you will get error
            val = 30;
            return val;
        }
        public static double test(int x, int y)
        {
            Console.WriteLine("+");
            return x + y;
        }
        public static double test(int x, double y)
        {
            Console.WriteLine("*");
            return x * y;
        }
        public static double test(double x, double y)
        {
            // here it called test(double x, double y), cause he did not find any identical match, so he considered is y is double, if no test(d, d) then, we will get error.
            Console.WriteLine("-");
            return x - y;
        }

        public static int printEvenElements(int[] arr, int y)
        {
            int x = 120;
            foreach (int i in arr)
            {
                if (isEven(i))
                // if isEven(int x)  is not static or it a local fun inside the printEvenElements, the you will get syntax error 
                {
                    Console.WriteLine(i + "  ");
                }
            }
            Console.WriteLine("");

            return x;

        }

        public static bool isEven(int x) => x % 2 == 0; // BodyExpressionMethod;

    }

}

