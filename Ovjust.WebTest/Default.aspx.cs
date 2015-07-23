using Ovjust.DbXpoProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ovjust.WebTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionString conn=new ConnectionString();
            this.TextBox1.Text = conn.DbServer;
            this.TextBox2.Text = conn.DbPort;
            this.TextBox3.Text = ConnectionString.GetString();

            try
            {
                SessionInit.Init();
                QueryLog log = new QueryLog(SessionInit.Sess);
                log.Save();
            }
            catch (Exception ex)
            {
                this.TextBox4.Text=string.Format("{0}\n{1}",ex.Message,ex.StackTrace);
            }
            
        }
    }
}