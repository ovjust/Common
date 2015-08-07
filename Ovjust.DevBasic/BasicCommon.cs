using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ovjust.DevBasic
{
    public class BasicCommon
    {
        static string systemName = "提示";
        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        /// <param name="buttons"></param>
        /// <param name="icon"></param>
        public static void ShowMessage(string text, Action action = null, string caption = null, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            if (action == null)
                MessageBox.Show(text, caption ?? systemName, buttons, icon);
            else
            {
                if (DialogResult.OK == MessageBox.Show(text, caption ?? systemName, buttons, icon))
                    action();
            }
        }

        /// <summary>
        /// 确认对话窗
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        /// <param name="action"></param>
        /// <param name="buttons"></param>
        /// <param name="icon"></param>
        /// 使用示例:
        ///         private void button1_Click(object sender, EventArgs e)
        ///   {
        ///       UIHelper.ShowConfirm("aaa", "确定", Function1);
        ///       //或
        ///        UIHelper.ShowConfirm("aaa", "确定", delegate { MessageBox.Show("11"); });
        ///    }

        ///    void Function1()
        ///    {
        ///         MessageBox.Show("11");
        ///     }
        public static void ShowConfirm(string text, Action action, string caption = null, MessageBoxButtons buttons = MessageBoxButtons.YesNo, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            if (DialogResult.Yes == MessageBox.Show(text, caption ?? systemName, buttons, icon))
            {
                action();
            }
        }
    }
}
