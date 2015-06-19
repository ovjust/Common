using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace DotNet_Utilities.鼠标键盘
{
    class Mouse_Event
    {
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll")]
        // static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr extraInfo);
        public static extern void mouse_event(int dwFlags, int dx, int dy, uint data, int extrtaInfo);
    
        //示例 SetCursorPos(Convert.ToInt32(arrLine[1]), Convert.ToInt32(arrLine[2]));
                //mouse_event(0x0002, 0, 0, 0, 0);//鼠标按下
                //mouse_event(0x0004, 0, 0, 0, 0);//鼠标松开
         //mouse_event(0x0001, 100, 10, 0, 0);//鼠标相对移动
        public static void MouseDown()
        {
            mouse_event(0x0002, 0, 0, 0, 0);
        }

        public static void MouseUp()
        {
            mouse_event(0x0004, 0, 0, 0, 0);
        }

        public static void MouseMove(int x, int y)
        {
            mouse_event(0x0001, x, y, 0, 0);//鼠标相对移动
        }
    
    }
}
