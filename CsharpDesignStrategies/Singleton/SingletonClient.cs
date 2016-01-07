// using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Singleton
{
    [TestFixture]
    class SingletonClient
    {
        [Test]
        public void UseSingleton()
       {
            // first method
            SingletonOne.DoSomething();
            // second method
            var s1 = new SingletonTwo();    // it will compile, but it will throw an error
            SingletonTwo.DoSomething();

            // third method
            var s2 = SingletonThree.CreateInstance();
            var s3 = SingletonThree.CreateInstance();
            Assert.AreSame(1, 1);
        }
    }
}
