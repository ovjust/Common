using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Data;

namespace Ovjust.DevBasic
{
    public partial class SourceGrid : BaseGrid
    {
        public SourceGrid()
        {
            InitializeComponent();
        }

        public event EventHandler<CallFrameworkArgs> OnCallFramework;

        public override void CallFramework()
        {
            if (OnCallFramework == null)
            {
                throw new Exception("OnCallFramework未实现。");
            }
            base.CallFramework();
        }
        CallFrameworkArgs arg;
        protected override void bgwLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            base.bgwLoading_DoWork(sender, e);
            arg = new CallFrameworkArgs();
            arg.PageInfo = PageInfo;
            //arg.SortInfo = gridView1.SortInfo;
            OnCallFramework(null, arg);

            if (arg.DataSource == null)
                throw new Exception("CallFrameworkArgs.DataSource不能为空。");
            if (PageInfo.IsAll)
            {
                PageInfo.PageCount = 1;
            }
            else
            {
                PageInfo.PageCount = Convert.ToInt32(Math.Ceiling(PageInfo.TotalCount * 1.0 / PageInfo.PageSize));
            }
        }

        protected override void bgwLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sortOuter = false;
            gridControl1.DataSource = arg.DataSource;
            if (isFirstSort)
            {
                foreach (SortProperty sort in ExtendSorting)
                {
                    var col = gridView1.Columns[sort.PropertyName.Trim('[', ']')];
                    if (col != null)
                        col.SortOrder = sort.Direction == SortingDirection.Ascending ? ColumnSortOrder.Ascending : ColumnSortOrder.Descending;
                }
                isFirstSort = false;
            }
            sortOuter = true;
           
            base.bgwLoading_RunWorkerCompleted(sender, e);
        }

    }
}
