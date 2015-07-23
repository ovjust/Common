using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace Ovjust.Common
{
    class ServiceInstall
    {
        //        1）安装
        //安装时会产生目录问题，所以安装代码如下： 
        public void Install()
        {
            string CurrentDirectory = System.Environment.CurrentDirectory;
            System.Environment.CurrentDirectory = CurrentDirectory + "\\Service";
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "Install.bat";
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            System.Environment.CurrentDirectory = CurrentDirectory;
        }
        //2）卸载
        //卸载时也会产生目录问题，所以卸载代码如下：
        public void Uninstall()
        {
            string CurrentDirectory = System.Environment.CurrentDirectory;
            System.Environment.CurrentDirectory = CurrentDirectory + "\\Service";
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "Uninstall.bat";
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            System.Environment.CurrentDirectory = CurrentDirectory;
        }
        //3）启动
        public void Start()
        {

            ServiceController serviceController = new ServiceController("ServiceTest");
            serviceController.Start();
        }
        //4）停止
        public void Stop()
        {

            ServiceController serviceController = new ServiceController("ServiceTest");
            if (serviceController.CanStop)
                serviceController.Stop();
        }
        //5）暂停/继续
        public void Parse()
        {
            ServiceController serviceController = new ServiceController("ServiceTest");
            if (serviceController.CanPauseAndContinue)
            {
                if (serviceController.Status == ServiceControllerStatus.Running)
                    serviceController.Pause();
                else if (serviceController.Status == ServiceControllerStatus.Paused)
                    serviceController.Continue();
            }
        }
        //6）检查状态
        public string GetState()
        {
            ServiceController serviceController = new ServiceController("ServiceTest");
            string Status = serviceController.Status.ToString();
            return Status;
        }

        public  void StartExeWatchExit()
        {
            System.Diagnostics.ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "notepad.exe";
            info.Arguments = "test.txt";
            info.WorkingDirectory = "D:\\";

            try
            {
               var proc = Process.Start(info);
                if (proc != null)
                {
                    // 监视进程退出

                    proc.EnableRaisingEvents = true;
                    // 指定退出事件方法

                    proc.Exited += new EventHandler(proc_Exited);
                }

            }
            catch (Exception ex)
            {
            }


        }

        // 外部程序退出事件
        void proc_Exited(object sender, EventArgs e)
        {
            // 记录外部程序退出日志
            string msg = "外部程序\"记事本\"已经退出";
            // 写入一个日志文件中
            // ....
        }
    }
}
