using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace Ovjust.WebTest
{
    /// <summary>
    /// WebServiceAjax 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WebServiceAjax : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = false)]
        public string TestWebClient()
        {
            WebClient wc = new WebClient();
            var s = wc.DownloadString("http://localhost:40629/WebServiceAjax.asmx/Get2?s=GETa");
            return "POST无参数";
        }


        [WebMethod]
        [ScriptMethod(UseHttpGet = false)]
        public string Post1()
        {
            return "POST无参数";
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = false)]
        public string Post2(string s)
        {
            return s;
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public string Get1()
        {
            return "GET无参数";
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public string Get2(string s)
        {
            return s;
        }  



    }
}
