using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ovjust.WebTest
{
    public partial class AddFile1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                TextBox1.Text += path;
                var fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                TextBox1.Text += "\n" + fileName;
                var fileFull = Path.Combine(path, fileName + ".txt");
                var sw = File.CreateText(fileFull);
                sw.Write(fileName);
                sw.Flush();
                sw.Close();
                sw.Dispose();
                TextBox1.Text += "\n saved";
            }
            catch (Exception ex)
            {
                TextBox1.Text += string.Format("\n{0}\n{1}", ex.Message, ex.StackTrace);
            }

            try
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                var fileName = "2015-06-25_03-28-33";
                var fileFull = Path.Combine(path, fileName + ".txt");
              var sr=  File.OpenText(fileFull);
             var line1= sr.ReadLine();
             TextBox2.Text += line1;
            }
            catch (Exception ex)
            {
                TextBox2.Text += string.Format("\n{0}\n{1}", ex.Message, ex.StackTrace);
            }


          var dataPath=  Environment.GetEnvironmentVariable("OPENSHIFT_DATA_DIR");
          string tmpFileName=null;
            try
            {
                var path = dataPath;
                TextBox3.Text += path;
                var fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                tmpFileName = fileName;
                TextBox3.Text += "\n" + fileName;
                var fileFull = Path.Combine(path, fileName + ".txt");
                var sw = File.CreateText(fileFull);
                sw.Write(fileName);
                sw.Flush();
                sw.Close();
                sw.Dispose();
                TextBox3.Text += "\n saved";
            }
            catch (Exception ex)
            {
                TextBox3.Text += string.Format("\n{0}\n{1}", ex.Message, ex.StackTrace);
            }

            try
            {
                var path = dataPath;
                var fileName = tmpFileName;
                var fileFull = Path.Combine(path, fileName + ".txt");
                var sr = File.OpenText(fileFull);
                var line1 = sr.ReadLine();
                TextBox3.Text +="read:"+ line1;
            }
            catch (Exception ex)
            {
                TextBox3.Text += string.Format("\n{0}\n{1}", ex.Message, ex.StackTrace);
            }

        }
    }
}