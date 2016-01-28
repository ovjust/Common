using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Ovjust.WinformTest
{
    public partial class ColorTest : Form
    {
        public ColorTest()
        {
            InitializeComponent();
        }

        List<Color> list = new List<Color>();
        private void ColorTest_Load(object sender, EventArgs e)
        {
            var pp= typeof(Color).GetProperties();
            var ff = typeof(Color).GetFields();
            var lights= pp.Where(p => p.Name.StartsWith("Light")).ToList();
            foreach (var light in lights)
            {
                
                comboBox1.Items.Add(light.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                PropertyInfo info = typeof(Color).GetProperty(comboBox1.Text);
               var color= (Color)info.GetValue(null, null);
               panel1.BackColor = color;
            }
            //{
            //    var info = typeof(Color).GetField(comboBox1.Text);
            //    var color = info.GetValue(null);
            //}
            //Color.FromName
        }
    }
}
