using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // A type defined inside a class
    // provide some restrictions ( encabsulation )
    class A
    {
        private int x;
        class B
        {
            // as Class B is an internal class, it can see all private/internal varibles of the container
            // no class except Class A can creat an instance of Class B
            private void test()
            {
                var a = new A();
                a.x = 10; ;
            }

        }

    }
    // combosite type is a class C has an instace of class D 
    class C
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public D d; // as it an ref type, intially it refers to null, it will throw NullExecption 

        public C()
        {
            d= new D();
         
        }

        public class D
        {
            public int x { get; set; }
            public int y { get; set; }
            
        }

    }

}
