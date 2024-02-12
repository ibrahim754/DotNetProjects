using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Debugging
    {
        public int value, dis;
        public Debugging (int value, int dis)
        {
            this.value = value;
            this.dis = dis;

        }
        public Debugging()
        {
            value = 0;
            dis = 0;
        }
        public int reduce(int val)
        {
            dis -= val;
            return dis;
        }
        public int distrbute() 
        {
            // it must be at least Catch or Finally, or both of them;
            try
            {
                int ret = value / dis;
                return ret;

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {


            }
            return -1;
        }
    }
}
