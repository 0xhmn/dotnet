using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting the property from reflection
            var sample = new Sample { Name = "John", Version = 1 };
            var sampleType = typeof(Sample);                    // Reflection.Sample
            var nameProperty = sampleType.GetProperty("Name");
            Console.WriteLine(nameProperty + "\t" + nameProperty.GetValue(sample));

            // Getting the method from reflection
            var myMethod = sampleType.GetMethod("MyMethod");
            myMethod.Invoke(sample, null);                      // Hello from method
        }

        public static void WatchAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                // Get types (classes)
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Type: " + type.Name + "\tBase Type: " + type.BaseType);
                Console.WriteLine("----------------------------------------------------");

                // Getting properties of each type
                var props = type.GetProperties();
                foreach (var p in props)
                {
                    Console.WriteLine("Properties: " + p.Name + "\tProperty type: " + p.PropertyType);
                }

                var mthods = type.GetMethods();
                foreach (var m in mthods)
                {
                    Console.WriteLine("Method: " + m);
                }
            }
        }
    }

    class Sample
    {
        public string Name { get; set; }    // this is a property
        public int Version { get; set; }    // this is a property
        public int Age;                     // this is a field

        public void MyMethod()
        {
            Console.WriteLine("Hello from method ");
        }
    }
}


