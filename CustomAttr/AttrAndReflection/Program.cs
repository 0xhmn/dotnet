using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttrAndReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            // Get types that has MyClassAttribute flag
            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyClassAttribute>().Any());
            foreach (var t in types)
            {
                Console.WriteLine("Class: " + t.Name);

                var methods = t.GetMethods().Where(m => m.GetCustomAttributes<MyMethodAttribute>().Any());
                foreach (var m in methods)
                {
                    Console.WriteLine(m);
                }
            }
        }
    }
    
    [MyClass]
    class Sample
    {
        public string Name { get; set; }    // this is a property
        public int Version { get; set; }    // this is a property
        public int Age;                     // this is a field

        [MyMethod]
        public void MyMethod()
        {
            Console.WriteLine("Hello from method ");
        }

        [MyMethod]
        public void MySecondMethod()
        {
            Console.WriteLine("Hello from method ");
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MyClassAttribute : Attribute
    {
        
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class MyMethodAttribute : Attribute
    {

    }
}
