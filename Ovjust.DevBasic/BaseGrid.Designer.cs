namespace Ovjust.DevBasic
{
    partial class BaseGrid
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barPaging = new DevExpress.XtraBars.Bar();
            this.barButtonAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonFilter = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonExport = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticLoading = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditRows = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticPageInfo = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonNext = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barPaging});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonAdd,
            this.barButtonFilter,
            this.barButtonRefresh,
            this.barButtonDelete,
            this.barButtonPrevious,
            this.barStaticPageInfo,
            this.barButtonNext,
            this.barButtonItem1,
            this.barToolbarsListItem1,
            this.barButtonExport,
            this.barStaticLoading,
            this.barEditRows,
            this.barStaticItem1});
            this.barManager1.MaxItemId = 13;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            // 
            // barPaging
            // 
            this.barPaging.BarName = "Tools";
            this.barPaging.DockCol = 0;
            this.barPaging.DockRow = 0;
            this.barPaging.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barPaging.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonFilter),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticLoading),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditRows),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonPrevious),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticPageInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonNext)});
            this.barPaging.OptionsBar.DrawBorder = false;
            this.barPaging.OptionsBar.UseWholeRow = true;
            this.barPaging.Text = "Tools";
            // 
            // barButtonAdd
            // 
            this.barButtonAdd.Caption = "新增";
            this.barButtonAdd.Id = 0;
            this.barButtonAdd.Name = "barButtonAdd";
            this.barButtonAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonFilter
            // 
            this.barButtonFilter.Caption = "显示过滤器";
            this.barButtonFilter.Id = 1;
            this.barButtonFilter.Name = "barButtonFilter";
            this.barButtonFilter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonFilter_ItemClick);
            // 
            // barButtonRefresh
            // 
            this.barButtonRefresh.Caption = "刷新";
            this.barButtonRefresh.Id = 2;
            this.barButtonRefresh.Name = "barButtonRefresh";
            this.barButtonRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonRefresh_ItemClick);
            // 
            // barButtonDelete
            // 
            this.barButtonDelete.Caption = "删除";
            this.barButtonDelete.Id = 3;
            this.barButtonDelete.Name = "barButtonDelete";
            this.barButtonDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDelete_ItemClick);
            // 
            // barButtonExport
            // 
            this.barButtonExport.Caption = "导出";
            this.barButtonExport.Id = 9;
            this.barButtonExport.Name = "barButtonExport";
            this.barButtonExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonExport_ItemClick);
            // 
            // barStaticLoading
            // 
            this.barStaticLoading.Caption = "数据查询中......";
            this.barStaticLoading.Id = 10;
            this.barStaticLoading.Name = "barStaticLoading";
            this.barStaticLoading.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticLoading.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "每页行数";
            this.barStaticItem1.Id = 12;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditRows
            // 
            this.barEditRows.Caption = "barEditItem1";
            this.barEditRows.Edit = this.repositoryItemComboBox1;
            this.barEditRows.EditValue = 10;
            this.barEditRows.Id = 11;
            this.barEditRows.Name = "barEditRows";
            this.barEditRows.EditValueChanged += new System.EventHandler(this.barEditRows_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "ALL"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barButtonPrevious
            // 
            this.barButtonPrevious.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonPrevious.Caption = "上一页";
            this.barButtonPrevious.Id = 4;
            this.barButtonPrevious.Name = "barButtonPrevious";
            this.barButtonPrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPrevious_ItemClick);
            // 
            // barStaticPageInfo
            // 
            this.barStaticPageInfo.Caption = "第1页/总1页 共10行";
            this.barStaticPageInfo.Id = 5;
            this.barStaticPageInfo.Name = "barStaticPageInfo";
            this.barStaticPageInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonNext
            // 
            this.barButtonNext.Caption = "下一页";
            this.barButtonNext.Id = 6;
            this.barButtonNext.Name = "barButtonNext";
            this.barButtonNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNext_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(881, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 402);
            this.barDockControlBottom.Size = new System.Drawing.Size(881, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 373);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(881, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 373);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "导出";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "导出";
            this.barToolbarsListItem1.Id = 8;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 29);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(881, 373);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // BaseGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BaseGrid";
            this.Size = new System.Drawing.Size(881, 402);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonFilter;
        private DevExpress.XtraBars.BarButtonItem barButtonRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonPrevious;
        private DevExpress.XtraBars.BarStaticItem barStaticPageInfo;
        private DevExpress.XtraBars.BarButtonItem barButtonNext;
        private DevExpress.XtraBars.BarButtonItem barButtonExport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        public DevExpress.XtraBars.Bar barPaging;
        public DevExpress.XtraBars.BarButtonItem barButtonAdd;
        private DevExpress.XtraBars.BarStaticItem barStaticLoading;
        protected DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barEditRows;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;

    }
}
