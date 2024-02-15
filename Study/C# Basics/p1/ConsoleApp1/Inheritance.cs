using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* 
     * Any class can only Inherit one class, but implement mutliple interfaces
     */

    /*
     * Upcasting -> Create Base class ref from Sub class ref, we see here only fields of BaseClass
     *  ex: Bird B = new Bird();
     *  Animal A = B; UpCasting
     *  now object A how you try to in
     *  Falcon F = (Falcon) A // here we would get exception, because object a is Bird, because it refers to b, so i can not conver from  Bird to Falcon
     *  Falcon F = A as Falcon // if there is an exception, it returns null
     *  ----------------------------------------------
     *  DownCasting -> Create a Sub Class ref from Base Class ref, we see here only fields of BaseClass, but here we must use 
     *  explicit Casting
     *  Ex:
     *  Bird B = new Bird();
     *  Animal A = B;  
     *  Bird b = (Bird) a;  // must use Casting, unless erorr
     */

    /*
     * Abstract Class is the class i can not have an object from it,
     * Sealed Class  is the class that can not be inherited. 
     */

    /*
     * Virual Method is used for mark this function as it can be overrided in the subclasses
     * Abstract Method is used for mark this function, it (must be overrided) in all subclasses;
     * Sealed Method is used for mark this function as i can not be overrided ( not allowed ).
     * base.Moving() -> base is a reversed keyword for calling the function in the base class;
     */
    public class Animal
    {
        public virtual void Moving()
        {
            Console.WriteLine("Moving");
        }
        public Animal(int x)
        {
            Console.WriteLine($" Base Class : {x}");
        }
        public Animal()
        {

        }
        protected void Toxic()
        {
            Console.WriteLine("You can see me only inside the base and sub classes");
        }
    }

    public class Bird : Animal
    {
        public Bird(int x) : base(x)
        {
            // base(x) -> it calles the base class's constructor and give it value x;

        }
        public override void Moving()
        {
            Console.WriteLine("Overrided methode");
        }
        public void Flying()
        {
            Console.WriteLine("Flying");
        }
    }
 
    
}




