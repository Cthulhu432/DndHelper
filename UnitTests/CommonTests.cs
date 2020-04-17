using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CommonTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testVar = 2 + 2;
            Assert.AreEqual(4, testVar);
        }
    }
}
