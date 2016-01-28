using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Ovjust.WebTest.FreePages
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        static int count = 1;
        [WebMethod]
        public object HelloWorld()
        {
            PageDataGroup dataGroup = new PageDataGroup();
            dataGroup.Time = DateTime.Now;
            var model=new PageDataModel();
            model.CtlId="divMain";
            model.ChangeType="append";
            model.Html = @"        <div> 
        <input type='text' id='txt1' value='1' />
        <input type='button' id='btn1' value='btn1' />
            </div>";
            model.Script=@"  <script>
        $('#txt1').val(110);
    </script>";
            model.RunFuction="";
            dataGroup.Datas.Add(model);
            return dataGroup;
        }

        class PageDataModel
        {
           public string CtlId;
           public string ChangeType;
           public string Html;
           public string Script;
           public string RunFuction;
           string test="aaa";
        }
        class PageDataGroup
        {
            public DateTime Time;
           public List<PageDataModel> Datas = new List<PageDataModel>();
            public string Script;
        }
    }
}
