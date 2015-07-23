using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ovjust.WebTest
{
    public class QueryLog:XPObject
    {
        public QueryLog()
            : base()
        {
        }

        public QueryLog(Session sess)
            : base(sess)
        {
        }

        public DateTime CreateTime { set; get; }
        [Size(4000)]
        public string QueryJson { set; get; }
         [Size(20)]
        public string UserIp { set; get; }
        [Size(500)]
         public string Exception { set; get; }
    }
}