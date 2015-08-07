using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Data;
using DevExpress.Xpo.DB;
using DevExpress.XtraGrid.Columns;

namespace Ovjust.DevBasic
{
    public partial class XpoGrid : BaseGrid
    {
        public XpoGrid()
        {
            InitializeComponent();
            //gridView1.StartSorting += gridView1_StartSorting;
           
            //gridView1.CustomColumnSort += gridView1_CustomColumnSort;
        }

       
    

      

       

        public event EventHandler<CallFrameworkArgs> OnCallFramework;
        public Session ConnectSession { set; get; }
        
        public XPCollection DataCollection { get; set; }
        public string DisplayableProperties { get; set; }
        public Type ObjectType { get; set; }

        public GroupOperator Criteria { get; set; }
        public GroupOperator ExtendCriteria = new GroupOperator();

        public override void CallFramework()
        {
            DataCollection = null;
            if (OnCallFramework != null)
            {
                CallFrameworkArgs arg = new CallFrameworkArgs();
                arg.PageInfo = PageInfo;
                OnCallFramework(null, arg);
            }
            base.CallFramework();
        }

        protected override void bgwLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            base.bgwLoading_DoWork(sender, e);
            if (DataCollection == null)
            {
                GroupOperator go;
                if(Criteria==null)
                    go=ExtendCriteria;
                else
                {
                    Criteria.Operands.Add(ExtendCriteria);
                    go=Criteria;
                }
                //SortingCollection sort;
                //if(Sorting==null)
                //    sort=ExtendSorting;
                //else
                //{
                //    Sorting.Add(ExtendSorting);
                //    sort=Sorting;
                //}
                PageInfo.TotalCount = (int)ConnectSession.Evaluate(ObjectType, CriteriaOperator.Parse("Count()"), go);
                DataCollection = new XPCollection(ConnectSession, ObjectType, go, ExtendSorting.ToArray());
                DataCollection.SkipReturnedObjects = PageInfo.PageSize * (PageInfo.PageIndex - 1);
                DataCollection.TopReturnedObjects = PageInfo.PageSize;
                DataCollection.Load();
            }
            //if (PageInfo.IsAll)
            //{
            //    PageInfo.PageCount = 1;
            //}
            //else
            //{
                
            //}
        }

        protected override void bgwLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sortOuter = false;
            gridControl1.DataSource =DataCollection;
           
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

        //private void XpoGrid_Load(object sender, EventArgs e)
        //{

        //}


    }
}
