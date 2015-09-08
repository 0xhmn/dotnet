using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_delegate_anFunction_lambda_review
{
    // delegate example
    delegate int Transformer(int x);


    class Program
    {
        public static int square(int x)
        {
            return x * x;
        }

         // delegate in method - passing the numbers by reference
        public static void Transforming(int[] nums, Transformer t)
        {
                foreach (int n in nums)
                {
                    Console.WriteLine(t(n));
                }
        }
    }

    
    // TESTING MULTICAST DELEGATE
    delegate void ProgressReporter(int x);
    class Util
    {
        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i);
                System.Threading.Thread.Sleep(100); // simulate the hard work
            }
        }

        
        public static void WriteProgressToConsole(int x)
        {
            Console.WriteLine(x);
        }
        public static void WrtieToFile(int percentComplete)
        {
            System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());
        }
    }

    class Test {
        static void Main(string[] args)
        {

            //****FROM PROGRAM CLASS ****//

            // using the delagate
            // very important
            Transformer t = Program.square;
            int result = t(3); // result = 9
            int result_old_way = t.Invoke(4); // == 16

            // delegate in method test
            int[] nums = { 1, 4, 2, 6, 22, 3, 7 };
            Program.Transforming(nums, Program.square);


            //***FROM UTIL CLASS - TESTING MULTICAST DELEGATE ***//
            ProgressReporter p = Util.WriteProgressToConsole;
            p += Util.WrtieToFile;
            Util.HardWork(p);



            // make the pause
            Console.ReadKey();
        }
    }

}

