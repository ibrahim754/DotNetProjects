using System;
namespace ConsoleApp
{
    /* impure function  ( cause side Affects )
     * 1- which depends on the global vars
     * 2- which modify the ref vars ( passed be ref )
     * 3- which uses Random Functions  ( interaction outside the world )
    */
    /* to make a function 
     * 1- using fucntion 
     * 2- using delegate -> use it to pass a function as a parm to another function
     * 3- using lamada expression
    */

    delegate void myDel(); // must be delcared outside the Program class
    /* .NET provided some generic delegate, instead of override  or use a lot of custom del
     * 1- Action ( NO parms, NO returns)
     * 2- Func ( INPUTS , Returns )
     * 3- Pred ( INPUTS , Boolean Return ) 
    */
    internal class Program
    {

        public static void Main(string[] args)
        { 
            List<string> list = new List<string>();
            list.Add("Ibrahim");
            list.Add("Ahmed");
            list.Add("Ibrim");
            list.Add("Ibim");
            list.Add("IbrahimSalman");
            list.Add("Ahmed");
            list.Add("Mohamed");
            list.Add("Rizq");
            list.Add("CR7");
            var res = ExtenstionProcdual.Filter(list, e => e.ToLowerInvariant().EndsWith("im"));
            var res2 = ExtenstionProcdual.Filter(list, e => e.ToLowerInvariant().StartsWith("a"));
 

            foreach (var item in res) { Console.WriteLine(item); }
            foreach (var item in res2) { Console.WriteLine(item); }


        }
        public static void m1()
        {
            Console.WriteLine("M1");
        }
        public static void m2(Action del)
        {
            del();
            Console.WriteLine("M2");

        }
        // yield keyWord()


    }
}