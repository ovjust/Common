namespace Ovjust.WinformTest
{
    partial class PopupSelectedDatesInnerEdit
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
            this.btnClearMonth = new System.Windows.Forms.Button();
            this.btnAddMonth = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.imageListBoxControl1 = new DevExpress.XtraEditors.ImageListBoxControl();
            this.dateNavigator1 = new Ovjust.WinformTest.MyDateNavigator();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearMonth
            // 
            this.btnClearMonth.Location = new System.Drawing.Point(245, 218);
            this.btnClearMonth.Name = "btnClearMonth";
            this.btnClearMonth.Size = new System.Drawing.Size(62, 23);
            this.btnClearMonth.TabIndex = 15;
            this.btnClearMonth.Text = "清空当月";
            this.btnClearMonth.UseVisualStyleBackColor = true;
            // 
            // btnAddMonth
            // 
            this.btnAddMonth.Location = new System.Drawing.Point(177, 218);
            this.btnAddMonth.Name = "btnAddMonth";
            this.btnAddMonth.Size = new System.Drawing.Size(62, 23);
            this.btnAddMonth.TabIndex = 14;
            this.btnAddMonth.Text = "添加当月";
            this.btnAddMonth.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(6, 218);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(62, 23);
            this.btnClearAll.TabIndex = 13;
            this.btnClearAll.Text = "清空所选";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // imageListBoxControl1
            // 
            this.imageListBoxControl1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.imageListBoxControl1.Location = new System.Drawing.Point(6, 29);
            this.imageListBoxControl1.Name = "imageListBoxControl1";
            this.imageListBoxControl1.Size = new System.Drawing.Size(165, 183);
            this.imageListBoxControl1.TabIndex = 12;
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.DateTime = new System.DateTime(2015, 8, 21, 0, 0, 0, 0);
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(177, 29);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(197, 183);
            this.dateNavigator1.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 14);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "已选周次（双击移除）";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(177, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(168, 14);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "日期选择器（请双击周一日期）";
            // 
            // PopupSelectedDatesInnerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnClearMonth);
            this.Controls.Add(this.btnAddMonth);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.imageListBoxControl1);
            this.Controls.Add(this.dateNavigator1);
            this.Name = "PopupSelectedDatesInnerEdit";
            this.Size = new System.Drawing.Size(382, 252);
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        protected System.Windows.Forms.Button btnClearMonth;
        protected System.Windows.Forms.Button btnAddMonth;
        protected System.Windows.Forms.Button btnClearAll;
        protected DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl1;
        protected MyDateNavigator dateNavigator1;
    }
}
