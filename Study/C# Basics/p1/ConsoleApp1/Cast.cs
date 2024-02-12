using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Casting
    {
 
        public static bool tryParsing(string s)
        {
            if (long.TryParse(s, out long number))
            {
                Console.WriteLine("Parse successuded");
                return true;
            }
            else
            {
                Console.WriteLine("Parse did not successded");
                return false;
            }
        }
        public static List<string> convertToBits(long x) // try to use Object instead of String, what would happen;
        {
            List<string> bits = new List<string>();
            var ar = BitConverter.GetBytes(x);
            foreach (var b in ar)
            {
                int bas = 8;
                var ret = Convert.ToString(b, bas).PadLeft(8, '0');
                bits.Add(ret);
            }
            return bits;
        }
        
        public static List<string> convertStringToArr(string str)
        {
            List<string> myList = new List<string>();
            char[] arr = str.ToCharArray();
            // toString(num,2 ) ->  conver from number to base 2;
            // toInt32(num,2) -> the number num is on base 2, then convert it to integer;
            foreach (char c in arr)
            {
                int asci = Convert.ToInt32(c);
                string bin = Convert.ToString(c, 2).PadLeft(8, '0');
                string hexa = Convert.ToString(c, 16).PadLeft(8, '0');
                string outPut = $"bin -> {bin} ,  asci ->   {asci}  ,   hexa ->   {hexa}";
                myList.Add(outPut);
            }
            return myList;
        }
        public static List<string> Cast(string hexaDec)
        {
            List<string> conv = new List<string>();
 
          
             var dec = Convert.ToInt32(hexaDec, 16);

            var hex = Convert.ToString(dec, 16);
            var anotherDec = Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            conv.Add($"Hexa {hex} -> Dec -> {dec} with another conversion  dec -> {anotherDec}");
            return conv;
        }
        public static int unBoxing(object x)
        {
            return (int)x;
        }
        public static object Boxing(int x)
        {
            return (object)x;
        }

    }
}
