using DotNet_Utilities;
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
    public partial class FormGridentColor : Form
    {
        public FormGridentColor()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           var value1= trackBar1.Value/100m;
          var color= GradientColorHelper.GetColorByValue(Color.Red, Color.Green, value1);
          colorEdit1.Color = color;
          panel1.BackColor = color;
        }
    }
}
