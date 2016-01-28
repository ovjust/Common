using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.Xml.XPath;
using System.IO;

namespace Ovjust.UnitTest
{
    [TestClass]
    public class XmlLoadTest
    {
        string xmlFilePath = "D:\\SinaStockDaysPriceSlice.html";
        [TestMethod]
        public void TestMethod1()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("D:\\SinaStockDaysPriceSlice.html");
        }

        [TestMethod]
        public void TestMethod2()
        {
            XPathDocument xmldContext = new XPathDocument("D:\\SinaStockDaysPriceSlice.html");

            XPathNavigator xnav = xmldContext.CreateNavigator(); XPathNodeIterator xpNodeIter = xnav.Select("datalist"); 
           
        }

        [TestMethod]
        public void CsQueryTest()
        {
          var text=  File.ReadAllText(xmlFilePath);
          //var cq = CsQuery.CQ.Create(text);
          //CsQuery.CQ cq = text;
        //var cq=  CsQuery.CQ.CreateFromFile(xmlFilePath);
          var cq = CsQuery.CQ.CreateFromUrl("http://market.finance.sina.com.cn/pricehis.php?symbol=sz000001&startdate=2015-08-03&enddate=2015-08-10");//有个小问题，编码不能自动识别
            //XmlDocument xml = new XmlDocument();
            //xml.Load("D:\\SinaStockDaysPriceSlice.html");
          var table1 = cq["table"];
         var table2 = cq["#datalist"];
         var table3 = cq[".list"];
         var maxPrice = cq[".list tbody tr"].First().Children().First().Html();//cq[".list thead tr"].Length [][]的写法无效，都等于只有最后一个[]
         var headTrs = cq[".list thead"].Children().Length;
        }


            [TestMethod]
        public void HTMLparserTest()
        {
          var text=  File.ReadAllText(xmlFilePath);
          var cq =new  Majestic12.HTMLparser(text);
            //XmlDocument xml = new XmlDocument();
            //xml.Load("D:\\SinaStockDaysPriceSlice.html");
          //var table1 = cq.("table");
          //table1 = cq.Find("#datalist");
          //table1 = cq.Find(".list");
        }
        

    }
}
