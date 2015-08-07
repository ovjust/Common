namespace Ovjust.DevBasic
{
    partial class FormSelectForExport
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
            this.simpleButtonSingle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAll = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // simpleButtonSingle
            // 
            this.simpleButtonSingle.Location = new System.Drawing.Point(29, 13);
            this.simpleButtonSingle.Name = "simpleButtonSingle";
            this.simpleButtonSingle.Size = new System.Drawing.Size(196, 33);
            this.simpleButtonSingle.TabIndex = 0;
            this.simpleButtonSingle.Text = "导出当前页";
            this.simpleButtonSingle.Click += new System.EventHandler(this.simpleButtonSingle_Click);
            // 
            // simpleButtonAll
            // 
            this.simpleButtonAll.Location = new System.Drawing.Point(29, 63);
            this.simpleButtonAll.Name = "simpleButtonAll";
            this.simpleButtonAll.Size = new System.Drawing.Size(196, 33);
            this.simpleButtonAll.TabIndex = 1;
            this.simpleButtonAll.Text = "导出全部（速度可能较慢）";
            this.simpleButtonAll.Click += new System.EventHandler(this.simpleButtonAll_Click);
            // 
            // FormSelectForExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 122);
            this.Controls.Add(this.simpleButtonAll);
            this.Controls.Add(this.simpleButtonSingle);
            this.Name = "FormSelectForExport";
            this.Text = "导出";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonSingle;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAll;
    }
}