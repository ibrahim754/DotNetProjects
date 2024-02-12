using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    // to make extenstions, it must be in static class
    public  static class ExtenstionProcdual
    {
        public static List<string> GetByFirstName(List<string> mylist, string s)
        {
            List<string> list = new List<string>();
            foreach (string name in mylist)
            {
                if (name.ToLowerInvariant().StartsWith(s.ToLowerInvariant()))
                {
                    list.Add(name);
                }

            }
            return list;
        }
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static IEnumerable<string> GetByFirstNameUsingYield(List<string> mylist, string s)
        {
            List<string> list = new List<string>();
            foreach (string name in mylist)
            {
                if (name.ToLowerInvariant().StartsWith(s.ToLowerInvariant()))
                {
                    yield return name;
                }

            }
        }
        // higher order function returns or takes Function as an input or ouput => func is ex
        // to make it general, instead of using multiple function, we use delegates
        // give me your condition, and i will do it for you
        public static IEnumerable<string> Filter(List<string> mylist, Func<string, bool>predicate)
        {
            foreach (string name in mylist)
            {
                if (predicate(name))
                {
                    yield return name;
                }

            }
        }
        public static IEnumerable<string> Filter2(this IEnumerable<string> mylist, Func<string, bool> predicate)
        {
            foreach (string name in mylist)
            {
                if (predicate(name))
                {
                    yield return name;
                }

            }
        }
    }
}
