using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace vstestvalidateontp_16._8._0
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, 4 - 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, 4 - 2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4,  6-2);
        }
    }
}
