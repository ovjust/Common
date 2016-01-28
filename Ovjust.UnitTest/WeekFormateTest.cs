using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ovjust.UnitTest
{
    [TestClass]
    public class WeekFormateTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var s = DateTime.Now.ToString("yyyy-MM-dd ddd HH:mm:ss");
            var s2 = DateTime.Now.ToString("yyyy-MM-dd ddd HH:mm:ss",new System.Globalization.CultureInfo("zh-cn"));
        }
    }
}
