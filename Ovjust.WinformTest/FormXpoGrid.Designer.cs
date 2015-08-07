namespace Ovjust.WinformTest
{
    partial class FormXpoGrid
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
            this.xpoGrid1 = new Ovjust.DevBasic.XpoGrid();
            this.SuspendLayout();
            // 
            // xpoGrid1
            // 
            this.xpoGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpoGrid1.Editable = false;
            this.xpoGrid1.Location = new System.Drawing.Point(0, 0);
            this.xpoGrid1.Name = "xpoGrid1";
            this.xpoGrid1.Size = new System.Drawing.Size(552, 301);
            this.xpoGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 301);
            this.Controls.Add(this.xpoGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevBasic.XpoGrid xpoGrid1;
    }
}