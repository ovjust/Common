using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet_Utilities
{
    class CHotKey示例
    {
        int keyRecord, keyStart, keyStop;
        string[] n2;

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    //  timer2.Interval = 100;
        //    //  timer3.Start();

        //    // this.textBox1.Focus();
        //    CHotKey hotkey = new CHotKey(this.Handle);
        //    keyRecord = hotkey.RegisterHotkey(Keys.F7, CHotKey.KeyFlags.MOD_NONE);
        //    keyStart = hotkey.RegisterHotkey(Keys.F8, CHotKey.KeyFlags.MOD_NONE);
        //    keyStop = hotkey.RegisterHotkey(Keys.F10, CHotKey.KeyFlags.MOD_NONE);

        //    // favKey = hotkey.RegisterHotkey(Keys.G, CHotKey.KeyFlags.MOD_CONTROL);
        //    // int nextKey = hotkey.RegisterHotkey(Keys.G, CHotKey.KeyFlags.MOD_CONTROL);
        //    hotkey.OnHotkey += new 获取鼠标的坐标.CHotKey.HotkeyEventHandler(OnHotkey);

        //}

        //private void OnHotkey(int hotkeyID)
        //{
        //    if (hotkeyID == keyRecord)
        //    {
        //        timer3.Start();
        //        richTextBox1.Text += timeCount + "," + label1.Text + "," + label2.Text + ",//" + count + "\n";   //奇怪，光标不往下走了
        //        timeCount = 0;
        //        count += 1;
        //    }
        //    else if (hotkeyID == keyStart)
        //    {
        //        n2 = richTextBox1.Lines;
        //        string sLine;
        //        string[] arrLine = new string[4];
        //        for (int i = 0; i < n2.Length; i++)
        //        {

        //            sLine = n2[i];
        //            if (sLine == "")
        //                continue;
        //            arrLine = sLine.Split(',');
        //            System.Threading.Thread.Sleep(Convert.ToInt32(arrLine[0]));
        //            SetCursorPos(Convert.ToInt32(arrLine[1]), Convert.ToInt32(arrLine[2]));
        //            mouse_event(0x0002, 0, 0, 0, 0);//鼠标按下
        //            mouse_event(0x0004, 0, 0, 0, 0);//鼠标松开

        //        }
        //    }
        //    else if (hotkeyID == keyStop)
        //    {
        //        Application.Exit();
        //    }

        //}

    }
}
