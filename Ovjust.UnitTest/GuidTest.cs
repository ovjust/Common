using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ovjust.UnitTest
{
    [TestClass]
    public class GuidTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var g = new Guid();
            var l = g.ToString().Length;
        }
    }
}
