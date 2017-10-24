using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;

namespace CowTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 45;
            string expected = "коров";

            string actual = CowClass.Cow(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 201;
            string expected = "корова";

            string actual = CowClass.Cow(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int n = 4;
            string expected = "коровы";

            string actual = CowClass.Cow(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
