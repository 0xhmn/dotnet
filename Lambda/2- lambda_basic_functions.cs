using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * from Albahari Book - page 135
 * 1- Lambda expression is = to a delegate
 * 2- Each parameter of the lambda expression corresponds to a delegate parameter, 
 * and the type of the expression (which may be void) corresponds 
 * to the return type of the delegate
 */

namespace ConsoleApplication2
{

    delegate int Transformer(int x);

    class Program
    {
        // method 2
        static int sqr2(int x, Transformer tr) { return tr(x); }

        static void Main(string[] args)
        {
            // method 1
            Transformer sqr = x=> x*x;

            // method 2
            int la = sqr2(4, x => x + x);
            Console.WriteLine(la);

            // method 3 using Func
            Func<int, int> funcTest_1 = x => x * 2;
            funcTest_1(3); //6

            // method 4, using Func with Employee object
            List<Employee> listEmployee = new List<Employee>() {
                new Employee{ID=10, Name="Steve"},
                new Employee{ID=3, Name="John"},
                new Employee{ID=15, Name="Mark"},
            };
            // instead of defining following delegate:
            // delegate string selector(Employee) ...
            Func<Employee, string> selector = x => "The employee name is " + x.Name;
            // for single employee
            Console.WriteLine(selector(new Employee { ID = 2, Name = "test" }));
            // for a list of employees
            IEnumerable<string> names = listEmployee.Select(selector);
            foreach(string name in names){
                Console.WriteLine(name);
            }

            // method 5, accepting more than one parameter
            Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
            totalLength("hooman", "sara"); //10

            // method 6, capturing outer variable
            // a lambda expression that captures variable is called a clousure
            int seed = 0;
            Func<int> natural = () => seed++;
            Console.WriteLine(natural());   // 0
            Console.WriteLine(natural());   // 1
            Console.WriteLine(natural());   // 2
            Console.WriteLine(seed);    // 3




            Console.Read();
        }

    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
