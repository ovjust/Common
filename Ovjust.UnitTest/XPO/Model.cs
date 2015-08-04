using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovjust.UnitTest.XPO
{
    public class XpoModel:XPObject
    {
        public string Name { set; get; }
        public int Age { set; get; }
    }
}
