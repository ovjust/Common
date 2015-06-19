//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DotNet_Utilities.视频
//{
//    class Class1示例
//    {
//        using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;

//namespace 摄像头控制
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }


//        CVideo video;

//        private void buttonConnect_Click(object sender, EventArgs e)
//        {
//            buttonDisConnect.Enabled = true;

//            video = new CVideo(pictureBox1.Handle, pictureBox1.Width, pictureBox1.Height);
//            video.StartWebCam();
//        }

//        private void buttonDisConnect_Click(object sender, EventArgs e)
//        {
//            buttonDisConnect.Enabled = false;

//            video.CloseWebCam();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            buttonDisConnect.Enabled = true;

//            video = new CVideo(pictureBox1.Handle, pictureBox1.Width, pictureBox1.Height);
//            video.StartWebCam();
//        }

//        private void buttonGrab_Click(object sender, EventArgs e)
//        {
            
//            try
//            {
//                DateTime dt = DateTime.Now;
//               // string fileName = DateTime.Now.ToShortDateString();// +DateTime.Now.ToLongTimeString();
//              string  fileName = dt.ToString("yyyy-MM-dd_HH-mm-ss_ffff");
//                fileName = @"d:\录像照片\" + fileName+ ".jpg";
//               string fileName2 = @"d:\aaa.bmp";
//                video.GrabImage(pictureBox1.Handle, fileName);
//              //  video.GrabImage(pictureBox1.Handle, fileName2);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.ToString());
//            }
//        }

//        private void buttonExit_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void buttonRecord_Click(object sender, EventArgs e)
//        {
//            DateTime dt = DateTime.Now;
//            string fileName = DateTime.Now.ToShortDateString();// +DateTime.Now.ToLongTimeString();
//            fileName = "d:\\" + fileName + "_" + dt.Hour + "-" + dt.Minute + "-" + dt.Second + "_" + dt.Millisecond + ".wmv";
//            video.StartVideoRecord(fileName);
//        }

//        private void buttonStopRecord_Click(object sender, EventArgs e)
//        {
//            video.StopVideoRecord();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            timer1.Start();
//        }

//        private void timer1_Tick(object sender, EventArgs e)
//        {
//            buttonGrab_Click(sender, e);
//        }
//    }
//}
//    }
//}
