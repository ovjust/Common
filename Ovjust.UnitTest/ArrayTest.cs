using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace Ovjust.UnitTest
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArrayList al = new ArrayList();
            var arr = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            al = new ArrayList(arr);
            //var list = new List<string>();
            //al = arr;
            //al = list;

            Hashtable hs = new Hashtable();
          
        }
    }
}
