using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class enumerateTest
    {
        public static void enumTest()
        {
            string name = "hooman";
            IEnumerator rator = name.GetEnumerator();
            while (rator.MoveNext())
            {
                Console.WriteLine(rator.Current);
            }
        }

        public static void enumTest2()
        {
            string[] names = { "Hooman", "Joe", "Deilan", "Down" };
            IEnumerable<string> fileterNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4);
            foreach (var f in fileterNames) { Console.WriteLine(f); }
        }

        public static void enumTest3() {
            string[] names = { "Hooman", "Joe", "Deilan", "Down" };
            IEnumerable<string> fileteNames = names.Where(n => n.Length >= 4);
            foreach (string n in fileteNames) { Console.WriteLine(n); }
        }

        public static void enumTest4()
        {
            string[] names = { "Hooman", "Joe", "Deilan", "Down" };
            var fileNames = names.Where(n => n.Length >=5);
            foreach (string n in fileNames) { Console.WriteLine(n); }
        }
    }
}
