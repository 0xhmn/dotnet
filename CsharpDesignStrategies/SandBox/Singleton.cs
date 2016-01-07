using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
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

    // not safe for cunurrency
    public class SingletonThree
    {
        // using private cosntructor
        // we can make instances only inside this class - not thread safe
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

    // same as above, but making an property
    public class SingletonThreeAndHalf
    {
        private static SingletonThreeAndHalf _instance;
        public static SingletonThreeAndHalf Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonThreeAndHalf();
                }
                return _instance;
            }
        }

        private SingletonThreeAndHalf()
        {
        }

    }

    // using Lazy loading
    public class SingletonBestPractice
    {
        private static readonly Lazy<SingletonBestPractice> lazyInstance = new Lazy<SingletonBestPractice>(() => new SingletonBestPractice(), true);

        private SingletonBestPractice()
        {
            Console.WriteLine("hit the SingletonBestPracitve Contructor");
        }
        public static SingletonBestPractice Instance { get { return lazyInstance.Value; } }

    }
}
