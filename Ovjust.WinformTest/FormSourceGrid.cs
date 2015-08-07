using DevExpress.Data.Filtering;
using DevExpress.Xpo;
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
    public partial class FormSourceGrid : Form
    {
        public FormSourceGrid()
        {
            InitializeComponent();
        }

        private void FormSourceGrid_Load(object sender, EventArgs e)
        {
            sourceGrid1.OnCallFramework += sourceGrid1_OnCallFramework;
        }

        void sourceGrid1_OnCallFramework(object sender, DevBasic.CallFrameworkArgs e)
        {
            var sess = XpoHelper.Sess;
            GroupOperator go=new GroupOperator();
            if (sourceGrid1.ExtendSorting.Count == 0)
            {
                sourceGrid1.ExtendSorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Ascending));
            }
            var ObjectType = typeof(XPClass1);
            e.PageInfo.TotalCount = (int)sess.Evaluate(ObjectType, CriteriaOperator.Parse("Count()"), go);
            var DataCollection = new XPCollection(sess, ObjectType, go, sourceGrid1.ExtendSorting.ToArray());
            DataCollection.SkipReturnedObjects = e.PageInfo.PageSize * (e.PageInfo.PageIndex - 1);
            DataCollection.TopReturnedObjects = e.PageInfo.PageSize;
            DataCollection.Load();
            e.DataSource = DataCollection;
        }
    }
}
