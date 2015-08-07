using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ovjust.DevBasic
{
    public partial class FormSelectForExport : Form
    {
        public FormSelectForExport()
        {
            InitializeComponent();
        }

        public FormSelectForExport(bool exportAll):this()
        {
            if (exportAll)
                simpleButtonSingle.Visible = false;
            else
                simpleButtonAll.Visible = false;
        }

        public bool ExportAll;
        private void simpleButtonSingle_Click(object sender, EventArgs e)
        {
            ExportAll = false;
            DialogResult = DialogResult.OK;
        }

        private void simpleButtonAll_Click(object sender, EventArgs e)
        {
            ExportAll = true;
            DialogResult = DialogResult.OK;
        }
    }
}
