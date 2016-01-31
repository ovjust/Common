using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace Ovjust.UnitTest.WebRequest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WebClient wc = new WebClient();
       
            var s = wc.DownloadString("http://localhost:40629/WebServiceAjax.asmx/Get2?s=GETa");
        }
    }
}
