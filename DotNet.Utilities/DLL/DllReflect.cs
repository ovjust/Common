using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace DotNet_Utilities
{
    class DllReflect
    {
        private void test()
        {
            Assembly ass = Assembly.Load("dll");  //加载dll文件
            Type tp = ass.GetType("dll.addclass");  //获取类名，必须 命名空间+类名
            Object obj = Activator.CreateInstance(tp);  //建立实例
            MethodInfo meth = tp.GetMethod("add");  //获取方法
            int t = Convert.ToInt32(meth.Invoke(obj, new Object[] { 2, 3 }));  //Invoke调用方法
            MessageBox.Show(t.ToString());
        }
    }
}
