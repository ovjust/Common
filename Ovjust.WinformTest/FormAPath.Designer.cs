namespace Ovjust.WinformTest
{
    partial class FormAPath
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
            this.radioStart = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEnd = new System.Windows.Forms.RadioButton();
            this.radioStop = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioStart
            // 
            this.radioStart.AutoSize = true;
            this.radioStart.Location = new System.Drawing.Point(6, 20);
            this.radioStart.Name = "radioStart";
            this.radioStart.Size = new System.Drawing.Size(71, 16);
            this.radioStart.TabIndex = 1;
            this.radioStart.TabStop = true;
            this.radioStart.Text = "设置起点";
            this.radioStart.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioStop);
            this.groupBox1.Controls.Add(this.radioEnd);
            this.groupBox1.Controls.Add(this.radioStart);
            this.groupBox1.Location = new System.Drawing.Point(407, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioEnd
            // 
            this.radioEnd.AutoSize = true;
            this.radioEnd.Location = new System.Drawing.Point(6, 42);
            this.radioEnd.Name = "radioEnd";
            this.radioEnd.Size = new System.Drawing.Size(71, 16);
            this.radioEnd.TabIndex = 2;
            this.radioEnd.TabStop = true;
            this.radioEnd.Text = "设置终点";
            this.radioEnd.UseVisualStyleBackColor = true;
            // 
            // radioStop
            // 
            this.radioStop.AutoSize = true;
            this.radioStop.Location = new System.Drawing.Point(6, 64);
            this.radioStop.Name = "radioStop";
            this.radioStop.Size = new System.Drawing.Size(71, 16);
            this.radioStop.TabIndex = 3;
            this.radioStop.TabStop = true;
            this.radioStop.Text = "设置障碍";
            this.radioStop.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(413, 192);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索路径";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 402);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(413, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormAPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 423);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAPath";
            this.Text = "FormAPath";
            this.Load += new System.EventHandler(this.FormAPath_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioStop;
        private System.Windows.Forms.RadioButton radioEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}