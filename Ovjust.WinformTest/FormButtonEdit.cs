using DevExpress.XtraEditors;
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
    public partial class FormButtonEdit : Form
    {
        public FormButtonEdit()
        {
            InitializeComponent();
            popupContainerControl1.Leave += popupContainerControl1_Leave;
            buttonEdit1.Properties.TextEditStyle =DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

        }

        void popupContainerControl1_Leave(object sender, EventArgs e)
        {
            edit.Text = textEdit1.Text;
        }

        ButtonEdit edit;
        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           edit= sender as ButtonEdit;
           textEdit1.Text = edit.Text;
            popupContainerControl1.Show();
        }

        private void popupContainerControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
