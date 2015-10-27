using System;
using System.Diagnostics;
using Application1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private LinkedList1933<string> _list1;

        [TestInitialize]
        public void SetUp()
        {
            Trace.WriteLine("test begins\n");
            _list1 = new LinkedList1933<string>();
            _list1.Add("This");
            _list1.Add("is");
            _list1.Add("a");
            _list1.Add("test");
        }

        [TestMethod]
        public void TestSize()
        {
            Trace.WriteLine("Testing Count Method\n");
            Assert.AreEqual(_list1.Count, 4);
        }

        [TestMethod]
        public void TestRemove()
        {
            Trace.WriteLine("Testing Remove Method\n");
            var t =_list1.Remove("This");
            Assert.IsTrue(t);
            Assert.AreEqual(_list1.Count, 3);
        }

        [TestMethod]
        public void TestContain()
        {
            Trace.WriteLine("Testing Contain Method\n");
            var t = _list1.Contains("This");
            Assert.IsTrue(t);
        }

        [TestMethod]
        public void TestInsert()
        {
            Trace.WriteLine("Testing Insert Method\n");
            _list1.Insert(3, "new");
            Assert.AreEqual(_list1.Count, 5);
            Assert.AreEqual(_list1[0], "This");
            Assert.AreEqual(_list1[1], "is");
            // Assert.AreEqual(_list1[4], "test");
        }

    }
}
