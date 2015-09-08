using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * from Albahari Book - page 139
 * - we need a delegate
 * 
 */

namespace ConsoleApplication2
{

    delegate int Transform(int x);

    class Program
    {
        static void Main(string[] args)
        {
            // lambda approach
            Transform sqr_lambda = x => x * x;
            // anonymous method
            Transform sqr = delegate(int x) { return x * x; };
            Console.WriteLine(sqr(3));
            // anonymous using Func<>
            Func<int, int> sqr_f = delegate(int x) { return x + x; };

            
            

            Console.Read();
        }

    }

}
