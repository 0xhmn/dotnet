using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SandBox
{
    [TestClass]
    public class SingletonClient
    {
        [TestMethod]
        public void UseSingleton()
        {
            // first method
            SingletonOne.DoSomething();
            // second method
            // var s1 = new SingletonTwo();    // it will compile, but it will throw an error
            SingletonTwo.DoSomething();
        }

        [TestMethod]
        public void UseThirdSingleton()
        {
            // third method
            var s2 = SingletonThree.CreateInstance();
            var s3 = SingletonThree.CreateInstance();
            Assert.AreEqual(s2, s3);
        }

        [TestMethod]
        public void UseThirdAndHalfSingleton()
        {
            // third method
            var s2 = SingletonThreeAndHalf.Instance;
            var s3 = SingletonThreeAndHalf.Instance;
            Assert.AreEqual(s2, s3);
        }

        [TestMethod]
        public void UseSingletonBestPractice()
        {
            // third method
            var s2 = SingletonBestPractice.Instance;
            var s3 = SingletonBestPractice.Instance;
            Assert.AreEqual(s2, s3);
        }

    }
}
