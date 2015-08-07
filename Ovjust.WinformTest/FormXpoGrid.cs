using Ovjust.DbXpoProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ovjust.WinformTest
{
    public partial class FormXpoGrid : Form
    {
        public FormXpoGrid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sess = XpoHelper.Sess;
            //for (var i = 0; i < 25; i++)
            //{
            //    var m1 = new XPClass1(sess);
            //    m1.Name = DateTime.Now.Millisecond.ToString();
            //    m1.Save();
            //}
            xpoGrid1.ConnectSession = sess;
            xpoGrid1.ObjectType = typeof(XPClass1);
            xpoGrid1.OnCallFramework += xpoGrid1_OnCallFramework;
            xpoGrid1.OnCallFrameworkFinished += xpoGrid1_OnCallFrameworkFinished;
            xpoGrid1.ExtendSorting.Add(new DevExpress.Xpo.SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending));
        }

        void xpoGrid1_OnCallFrameworkFinished(object sender, DevBasic.CallFrameworkFinishedArgs e)
        {
            e.GridView.Columns["Name"].Caption = "Name2";
        }

        void xpoGrid1_OnCallFramework(object sender, DevBasic.CallFrameworkArgs e)
        {
           
        }
    }
}
