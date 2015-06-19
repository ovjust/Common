using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DotNet_Utilities.鼠标键盘
{
    class MousePosition
    {
        public static Point GetMousePosition()
        {
            Point p = Control.MousePosition;
            //Point p = Cursor.Position;都可以,都是全局的。
            return p;
        }

        //获取 设置鼠标形状
        //public static Cursor GetMouseState()
        //{
        //    if (Cursor == Cursors.Hand)
        //    {
        //        label3.Text = "Hand";
        //        Cursor = Cursors.Default;
        //    }
        //    else
        //    {
        //        label3.Text = "NoHand";
        //        Cursor = Cursors.Hand;
        //    }
        //}
    }
}
