using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ovjust.WinformTest
{
    public partial class Form1DgvCustomRow : Form
    {
        public Form1DgvCustomRow()
        {
            InitializeComponent();
        }

        private void Form1DgvCustomRow_Load(object sender, EventArgs e)
        {
            NewMethod1();
            NewMethod2();
        }

        private void NewMethod2()
        {
            DataGridViewRow row = new DataGridViewRow();
            {
                DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
                textboxcell.Value = "aaa";
                row.Cells.Add(textboxcell);
            }
            {
                DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
                textboxcell.Value = "aaa";
                row.Cells.Add(textboxcell);
            }
            DataGridViewComboBoxCell comboxcell = new DataGridViewComboBoxCell();
            row.Cells.Add(comboxcell);
            dataGridView1.Rows.Add(row);
        }

        private void NewMethod1()
        {
            int index = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[index].Cells[0].Value = "1";
            this.dataGridView1.Rows[index].Cells[1].Value = "2";
            this.dataGridView1.Rows[index].Cells[2].Value = "监听";
        }


    }
}
