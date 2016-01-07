using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// restricts the instantiation of a class to `only` one object
    /// using abstract class: cannot have a constructor and cannot be instantiated directly
    /// </summary>
    public static class SingletonOne
    {
        public static void DoSomething()
        {        
        }
    }

    public class SingletonTwo
    {
        public SingletonTwo()
        {
            // cannot make any instance - only can have access to static methods
            throw new Exception("It's a singleton");
        }
        public static void DoSomething()
        {
        }
    }

    public class SingletonThree
    {
        // using private cosntructor
        // we can make instances only inside this class
        private SingletonThree()
        {

        }

        private static SingletonThree _instance;

        public static SingletonThree CreateInstance()
        {
            return _instance ?? (_instance = new SingletonThree());
        }

        public static void DoSomething()
        {
        }
    }
}
