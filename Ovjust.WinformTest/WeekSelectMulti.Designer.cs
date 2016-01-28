namespace Ovjust.WinformTest
{
    partial class WeekSelectMulti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeekSelectMulti));
            this.popupContainerEdit1 = new DevExpress.XtraEditors.PopupContainerEdit();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.imageListBoxControl1 = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // popupContainerEdit1
            // 
            this.popupContainerEdit1.Location = new System.Drawing.Point(143, 12);
            this.popupContainerEdit1.Name = "popupContainerEdit1";
            this.popupContainerEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupContainerEdit1.Size = new System.Drawing.Size(361, 20);
            this.popupContainerEdit1.TabIndex = 0;
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.EditValue = "";
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(143, 53);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null)});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(361, 20);
            this.checkedComboBoxEdit1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "popup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "checkList";
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.DateTime = new System.DateTime(2015, 8, 21, 0, 0, 0, 0);
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(377, 95);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(197, 183);
            this.dateNavigator1.TabIndex = 4;
            this.dateNavigator1.CustomDrawDayNumberCell += new DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventHandler(this.dateNavigator1_CustomDrawDayNumberCell);
            this.dateNavigator1.DoubleClick += new System.EventHandler(this.dateNavigator1_DoubleClick);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Items.AddRange(new object[] {
            "21212",
            "232",
            "32",
            "3232323",
            "23",
            "23",
            "2"});
            this.listBoxControl1.Location = new System.Drawing.Point(206, 95);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(165, 83);
            this.listBoxControl1.TabIndex = 5;
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.Appearance.Image = global::Ovjust.WinformTest.Properties.Resources.refresh;
            this.checkedListBoxControl1.Appearance.Options.UseImage = true;
            this.checkedListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("11", "222"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("3232", "5554"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("33", "3332")});
            this.checkedListBoxControl1.Location = new System.Drawing.Point(13, 95);
            this.checkedListBoxControl1.MultiColumn = true;
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.checkedListBoxControl1.Size = new System.Drawing.Size(187, 167);
            this.checkedListBoxControl1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.checkedListBoxControl1.TabIndex = 6;
            // 
            // imageListBoxControl1
            // 
            this.imageListBoxControl1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.imageListBoxControl1.ImageList = this.imageList1;
            this.imageListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageListBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, 0),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, 0),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, 0),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, 0),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, 0),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, 0)});
            this.imageListBoxControl1.Location = new System.Drawing.Point(206, 206);
            this.imageListBoxControl1.Name = "imageListBoxControl1";
            this.imageListBoxControl1.Size = new System.Drawing.Size(165, 129);
            this.imageListBoxControl1.TabIndex = 7;
            this.imageListBoxControl1.SelectedIndexChanged += new System.EventHandler(this.imageListBoxControl1_SelectedIndexChanged);
            this.imageListBoxControl1.DoubleClick += new System.EventHandler(this.imageListBoxControl1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            // 
            // WeekSelectMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 356);
            this.Controls.Add(this.imageListBoxControl1);
            this.Controls.Add(this.checkedListBoxControl1);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.dateNavigator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedComboBoxEdit1);
            this.Controls.Add(this.popupContainerEdit1);
            this.Name = "WeekSelectMulti";
            this.Text = "WeekSelectMulti";
            this.Load += new System.EventHandler(this.WeekSelectMulti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PopupContainerEdit popupContainerEdit1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
        private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl1;
        private System.Windows.Forms.ImageList imageList1;
    }
}