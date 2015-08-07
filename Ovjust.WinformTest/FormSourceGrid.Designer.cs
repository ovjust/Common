namespace Ovjust.WinformTest
{
    partial class FormSourceGrid
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
            this.sourceGrid1 = new Ovjust.DevBasic.SourceGrid();
            this.SuspendLayout();
            // 
            // sourceGrid1
            // 
            this.sourceGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceGrid1.Editable = false;
            this.sourceGrid1.Location = new System.Drawing.Point(0, 0);
            this.sourceGrid1.Name = "sourceGrid1";
            this.sourceGrid1.Size = new System.Drawing.Size(579, 382);
            this.sourceGrid1.TabIndex = 0;
            // 
            // FormSourceGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 382);
            this.Controls.Add(this.sourceGrid1);
            this.Name = "FormSourceGrid";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormSourceGrid_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevBasic.SourceGrid sourceGrid1;

    }
}