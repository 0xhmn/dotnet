using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * from here: http://goo.gl/K0bJV6
 * WHAT IS THE RELATIONSHIP BETWEEN DELEGATE AND LAMBDA
 */

namespace ConsoleApplication2
{
    // delegate #1
    delegate bool delCondition(int x);

    class Program
    {

        // filter less than five
        public static bool a(int x) {return x < 5;}
        public static bool b(int x) { return x > 10; }


        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 4, 6, 2, 34, 6, 3 };
            // using delegate the old way
            IEnumerable<int> result = GetAllNumbers(numbers, a);
            // using lambda
            IEnumerable<int> result_lambda = GetAllNumbers(numbers, x => x < 5);

            foreach (int i in result_lambda)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }

        static IEnumerable<int> GetAllNumbers(IEnumerable<int> numbers, delCondition del)
        {
            foreach (int i in numbers)
            {
                if (del(i))
                    yield return i;
            }
        }

    }
}
