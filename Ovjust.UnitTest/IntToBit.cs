using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Ovjust.UnitTest
{
    [TestClass]
    public class IntToBit
    {
        [TestMethod]
        public void TestMethod1()
        {
            var l1 = GetItems(511);
            var l2 = GetItems(213);
            var l3 = GetItems(298);
           var s1= string.Join(",", l1);
           var s2= string.Join(",", l2);
           var s3= string.Join(",", l3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var l1 = GetItems2(511);
            var l2 = GetItems2(213);
            var l3 = GetItems2(298);
            var s1 = string.Join(",", l1);
            var s2 = string.Join(",", l2);
            var s3 = string.Join(",", l3);
        }


        List<int> GetItems(int i)
        {
            int pos = 0;
            List<int> list = new List<int>();
            while (i > 0)
            {
                if (i % 2 == 1)
                    list.Add( 1 << pos);
                i = i / 2;
                pos++;
            }
           return list;
        }


        List<int> GetItems2(int total)
        {
            List<int> list = new List<int>();
            var str = Convert.ToString(total, 2);
            var len = str.Length;
            var lenMax = len - 1;
            for (var i = 0; i < len; i++)
            {
                var b = str[lenMax - i] == '1';
                if (b)
                {
                    var value = (int)Math.Pow(2, i);
                    list.Add(value);
                }
            }
            return list;
        }
    }
}
