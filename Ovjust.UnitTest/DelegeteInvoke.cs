using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices;

namespace Ovjust.UnitTest
{
    [TestClass]
    public class DelegeteInvoke
    {
        public delegate int AddHandler(int a, int b);
        public class 加法类
        {
            public static int Add(int a, int b)
            {
                Console.WriteLine("开始计算：" + a + "+" + b);
                Thread.Sleep(2000); //模拟该方法运行三秒
                Console.WriteLine("计算完成！");
                return a + b;
            }
        }

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;


    [TestInitialize]
        public void OnStart()
        {
            //System.Diagnostics.Process.Start("cmd.exe", "/k echo '程序调试结果信息！'");
            AllocConsole();
            AttachConsole(ATTACH_PARENT_PROCESS);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("===== 同步调用 SyncInvokeTest =====");
            AddHandler handler = new AddHandler(加法类.Add);
            int result = handler.Invoke(1, 2);

            Console.WriteLine("继续做别的事情。。。");

            Console.WriteLine(result);
            //Console.ReadKey();
        }
        /*运行结果：
         ===== 同步调用 SyncInvokeTest =====
         开始计算：1+2
         计算完成！
         继续做别的事情。。。
         3       */


        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("===== 异步调用 AsyncInvokeTest =====");
            AddHandler handler = new AddHandler(加法类.Add);

            //IAsyncResult: 异步操作接口(interface)
            //BeginInvoke: 委托(delegate)的一个异步方法的开始
            IAsyncResult result = handler.BeginInvoke(1, 2, null, null);

            Console.WriteLine("继续做别的事情。。。");

            //异步操作返回
            Console.WriteLine(handler.EndInvoke(result));
            Console.ReadKey();
        }
        /*运行结果：
         ===== 异步调用 AsyncInvokeTest =====
         继续做别的事情。。。
         开始计算：1+2
         计算完成！
         3       */


        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("===== 异步回调 AsyncInvokeTest =====");
            AddHandler handler = new AddHandler(加法类.Add);

            //异步操作接口(注意BeginInvoke方法的不同！)
            IAsyncResult result = handler.BeginInvoke(1, 2, new AsyncCallback(回调函数), "AsycState:OK");

            Console.WriteLine("继续做别的事情。。。");
            Console.ReadKey();
        }

        static void 回调函数(IAsyncResult result)
        {      //result 是“加法类.Add()方法”的返回值

            //AsyncResult 是IAsyncResult接口的一个实现类，引用空间：System.Runtime.Remoting.Messaging
            //AsyncDelegate 属性可以强制转换为用户定义的委托的实际类。
            AddHandler handler = (AddHandler)((AsyncResult)result).AsyncDelegate;
            Console.WriteLine(handler.EndInvoke(result));
            Console.WriteLine(result.AsyncState);
        }
        /*运行结果：
        ===== 异步回调 AsyncInvokeTest =====
        开始计算：1+2
        继续做别的事情。。。
        计算完成！
        3
        AsycState:OK
                 */

    }
}
