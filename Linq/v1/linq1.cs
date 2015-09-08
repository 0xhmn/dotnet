using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Linq
{
    class linq1
    {
        // test 1
        public static void Linq1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 1, 32, 4, 67 };

            var result = from n in numbers
                         where n < 5
                         select n;
            foreach (var i in result) { Console.WriteLine(i); }
        }

        // test 2
        public static void Linq2()
        {
            string[] names = { "Hooman", "Joe", "Deilan", "Down" };
            IEnumerable<string> fileterNames = from n in names
                                               where n.Contains("J")
                                               select n;
            foreach (var f in fileterNames) { Console.WriteLine(f); }
        }

        // chaining them
        public static void Linq3()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());
            foreach (string s in query) { Console.WriteLine(s); }


        }

    }
}
