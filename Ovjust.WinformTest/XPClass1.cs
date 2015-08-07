using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovjust.WinformTest
{
    public class XPClass1:XPObject
    {
        public XPClass1()
            : base()
        { }
        public XPClass1(Session sess)
            : base(sess)
        {

        }
        [DisplayName("名称")]
        public string Name { set; get; }
    }
}
