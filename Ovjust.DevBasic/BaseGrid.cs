using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Xpo;
using DevExpress.Data;
using DevExpress.Xpo.DB;

namespace Ovjust.DevBasic
{
    public partial class BaseGrid : UserControl
    {
        protected bool reload = true;
        protected BaseGrid()
        {
            InitializeComponent();
            //barEditRows.EditValue = 10;
            gridView1.EndSorting += gridView1_EndSorting;
            barStaticPageInfo.Caption = string.Empty;
            bgwLoading.DoWork += bgwLoading_DoWork;
            bgwLoading.RunWorkerCompleted += bgwLoading_RunWorkerCompleted;
        }

        protected virtual void bgwLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CallFrameworkFinished();
        }
        protected virtual void bgwLoading_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        PageInfo pageInfo = new PageInfo();
        public PageInfo PageInfo { get { return pageInfo; } }

        bool editable;
        public bool Editable
        {
            get { return editable; }
            set
            {
                editable = value;
                gridView1.OptionsBehavior.Editable = editable;
            }
        }
        /// <summary>
        /// 排序信息
        /// </summary>
        public SortingCollection ExtendSorting = new SortingCollection();

        protected bool sortOuter = false;
        protected bool isFirstSort = true;
        BackgroundWorker bgwLoading = new BackgroundWorker();

        public event EventHandler OnNewRow;
      
        public event EventHandler<CallFrameworkFinishedArgs> OnCallFrameworkFinished;
        public event EventHandler<GridSelectedRowArgs> OnDeleteRow;
        public event EventHandler<GridSelectedRowArgs> OnDeleteRowFinished;
        //public event EventHandler<GridSelectedRowArgs> OnUpdateRow;
        //public event EventHandler<GridSelectedRowArgs> OnUpdateRowFinished;
        public event EventHandler OnExport;
        public event EventHandler OnExportFinished;
        public event EventHandler<GridSelectedRowArgs> OnGridDoubleClicked;
        public event EventHandler OnRefresh;

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (OnNewRow != null)
                OnNewRow(sender, e);
        }

        private void barButtonRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (OnRefresh != null)
                OnRefresh(sender, e);
            CallFramework();
        }
      
        /// <summary>
        /// 加载数据
        /// </summary>
        public virtual void CallFramework(bool reload=true)
        {
            this.reload = reload;
            barStaticLoading.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            if (!bgwLoading.IsBusy)
                bgwLoading.RunWorkerAsync();
        }

        private void CallFrameworkFinished()
        {
            barStaticLoading.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            CheckPageButtonEnable();
            barStaticPageInfo.Caption = string.Format("第{0}页/总{1}页 共{2}行", pageInfo.PageIndex, pageInfo.PageCount, pageInfo.TotalCount);
            if (OnCallFrameworkFinished != null)
            {
                CallFrameworkFinishedArgs arg = new CallFrameworkFinishedArgs(gridView1);
                OnCallFrameworkFinished(null, arg);
            }
        }

        private void CheckPageButtonEnable()
        {
            if (pageInfo.IsAll)
                pageInfo.PageIndex = pageInfo.PageCount = 1;
            else
            {
                PageInfo.PageCount = Convert.ToInt32(Math.Ceiling(PageInfo.TotalCount * 1.0 / PageInfo.PageSize));
            }
            barButtonPrevious.Enabled = pageInfo.PageIndex != 1;
            barButtonNext.Enabled = !(PageInfo.IsAll || PageInfo.PageIndex == PageInfo.PageCount);
        }

        private void barButtonFilter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow = !gridView1.OptionsView.ShowAutoFilterRow;
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           var row= gridView1.GetFocusedRow();
           if (row == null)
           {
               BasicCommon.ShowMessage("未选择行。");
           }
           BasicCommon.ShowConfirm("确定要删除选中行吗?", delegate
           {
               DeleteRow();
           });
        }

        protected virtual void DeleteRow()
        {

        }

        private void barButtonExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSelectForExport dlg = new FormSelectForExport();
            if (DialogResult.OK == dlg.ShowDialog(this.FindForm()))
            {
                if (dlg.ExportAll)
                {

                }
                else
                {

                }
            }
        }

        private void barButtonNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PageInfo.PageIndex < PageInfo.PageCount)
                pageInfo.PageIndex++;
            CallFramework();
        }

        private void barButtonPrevious_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PageInfo.PageIndex >1)
                pageInfo.PageIndex--;
            CallFramework();
        }

        void gridView1_EndSorting(object sender, EventArgs e)
        {
            this.pageInfo.IsSorting = sortOuter;
            if (sortOuter)
            {
                PageInfo.PageIndex = 1;
                ExtendSorting.Clear();
                foreach (GridColumnSortInfo sort in gridView1.SortInfo)
                {
                    //if (sort.SortOrder == ColumnSortOrder.None)
                    //    continue;
                    ExtendSorting.Add(new SortProperty(sort.Column.FieldName, sort.SortOrder == ColumnSortOrder.Ascending ? SortingDirection.Ascending : SortingDirection.Descending));
                }
                CallFramework();
            }
        }

        private void barEditRows_EditValueChanged(object sender, EventArgs e)
        {
            if (barEditRows.EditValue == "ALL")
            {
                PageInfo.IsAll = true;
                //pageInfo.PageIndex = pageInfo.PageCount = 1;
                pageInfo.PageSize = int.MaxValue;
            }
            else
            {
                PageInfo.IsAll = false;
                pageInfo.PageIndex = 1;
               
                int pageSize = 10;
                if (!int.TryParse(barEditRows.EditValue.ToString(), out pageSize))
                {
                    barEditRows.EditValue = pageSize;
                }
                pageInfo.PageSize =pageSize;
                //pageInfo.PageCount=
            }
                //CheckPageButtonEnable();
            CallFramework();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if(OnGridDoubleClicked!=null)
            {
                var row=gridView1.GetFocusedRow();
                GridSelectedRowArgs arg=new GridSelectedRowArgs(row);
                OnGridDoubleClicked(sender, arg);
            }
        }
        
    }

    public class PageInfo
    {
        public int TotalCount { set; get; }
        public int PageCount { set; get; }
        int pageIndex = 1;

        public int PageIndex
        {
            get { return pageIndex; }
            set { pageIndex = value; }
        }

        int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }
       
        public bool IsAll { set; get; }

        public bool IsSorting { set; get; }
    }
    public class CallFrameworkArgs : EventArgs
    {
        public PageInfo PageInfo { set; get; }
        public object DataSource { set; get; }
        public bool Reload { set; get; }
        //public GridColumnSortInfoCollection SortInfo { set; get; }
    }
    public class CallFrameworkFinishedArgs : EventArgs
    {
        protected GridView m_GirdView;

        public CallFrameworkFinishedArgs(GridView gridView)
        {
            m_GirdView = gridView;
        }

        public GridView GridView { get { return m_GirdView; } }
    }

    public class GridSelectedRowArgs : EventArgs
    {
        protected object m_SelectRow;
        public GridSelectedRowArgs(object selectRow)
        {
            m_SelectRow = selectRow;
        }
        public object SelectRow { get { return m_SelectRow; } }
        public bool Sucess { set; get; }
        public Exception Except { set; get; }
        public string Message { set; get; }
    }

}
