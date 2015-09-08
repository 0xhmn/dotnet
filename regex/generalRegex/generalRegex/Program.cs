using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace generalRegex
{
    delegate bool delCondition(int x);
    delegate int Transformer(int x);
    class Program
    {
        static bool greaterThanFive(int x) {
            return true ? x > 5 : false;
        }
        static int squar(int x)
        {
            return x * x;
        }

        static void Main()
        {
            int[] numbers = { 2, 3, 5, 6, 3, 43, 10 };
            IEnumerable<int> nums = GetAllNumbers(numbers, greaterThanFive);
            IEnumerable<int> num_2 = GetAllNumbers(numbers, x => x > 5);
            foreach (int i in num_2)
            {
                Console.WriteLine(i);
            }

            Transformer transformer = x => x * x;
            Console.WriteLine(transformer(3));

            Func<int, int> func_1 = x => x*3;
            Console.WriteLine(func_1(4));

            List<Employee> list = new List<Employee>()
            {
                new Employee{ID = 10, Name = "John"},
                new Employee{ID = 13, Name = "Doe"},
                new Employee{ID = 55, Name = "Mark"},           
            };
            Func<Employee, string> func_2 = x => x.Name;
            foreach (Employee e in list)
            {
                Console.WriteLine(func_2(e));
            }

            // making the pause
            Console.ReadKey();
        }

        static IEnumerable<int> GetAllNumbers(IEnumerable<int> numbs, delCondition del)
        {
            foreach (int i in numbs)
            {
                if (del(i))
                {
                    yield return i;
                }
            }
        }
    }

    class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }
}
