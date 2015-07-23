using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ovjust.UnitTest.VirturlOverwriteNew
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a1 = new ClassA();
            var aa1 = new ClassAA();
            var a2 = (ClassA)aa1;
        }
    }
}
