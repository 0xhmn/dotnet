using System;
using System.Linq;
using System.Reflection;

namespace CustomAttr
{
    /// <summary>
    /// Naming: SampleAttribute -> will create the attribute [Sample] OR [SampleAttribute]
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // checking all of the attributes
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.GetCustomAttributes<SampleAttribute>().Any()
                select t;

            foreach (var t in types)
            {
                Console.WriteLine("Class name using [Sample]: " + t.Name);

                foreach (var p in t.GetProperties())
                {
                    Console.WriteLine("Property name is " + p.Name);
                }
            }

            Console.Read();
        }
        
        public class SampleAttribute : Attribute
        {
            public string Name { get; set; }
            public int Version { get; set; }
        }

        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Enum)] // apply this attr just to methods
        public class OnlyClassAttribute : Attribute
        {
            
        }

        [Sample(Name = "John", Version = 12)]
        public class Test
        {
            [Sample]
            public int IntValue { get; set; }

            [OnlyClass]
            [Sample]
            public void PrintVal() { }
        }

        public class NoAttribute
        {
            
        }
    }
}
