using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Ovjust.UnitTest
{
    [Serializable]
    public class CallResult
    {
        public CallResult() { }

        public string BMsg { get; set; }
        public object ResultObj { get; set; }
        public bool State { get; set; }
        public int Tag { get; set; }
        public string VMsg { get; set; }

        public List<SmsResult> SmsResults { get; set; }


        public CallResult GenerateSendMsg(string strBatch, List<SmsDataModel_Mobile> userMsgContent)
        {
            if (userMsgContent is List<SmsDataModel_Mobile>)
            {

            }
            return null;
        }
    }


    public class SmsDataModel
    {
        public string Content{set;get;}
    }

    public class SmsDataModel_UserId : SmsDataModel
    {
        public Guid UserId{set;get;}
    }

    public class SmsDataModel_Mobile : SmsDataModel
    {
        public string Mobile{set;get;}
    }

     public class SmsResult
     {
          public ESmsResult Result{set;get;}
     }

    public class SmsResult_UserId:SmsResult
    {
        public Guid UserId{set;get;}
    }

     public class SmsResult_Mobile:SmsResult
    {
        public ESmsResult Result{set;get;}
    }

    public enum ESmsResult
    {
        [Description("发送成功")]
        Sucess=1,
        [Description("手机号为空，已取消发送")]
        Empty,
        NotReceive,
        WaitSend//等等
    }
}
