using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DotNet_Utilities.鼠标键盘
{
    class KeySend
    {
        public static void MySendKey(string keys)
        {
            SendKeys.Send(keys);
            //特殊键  SendKeys.Send("{Backspace}");
            //SendKeys.Send("{Enter}");
        }

    }
}
