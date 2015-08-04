//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DotNet_Utilities.文件相关.启动程序进程
//{
//    class ServiceInstall
//    {
//        1）安装
//安装时会产生目录问题，所以安装代码如下： 
//1
//2
//3
//4
//5
//6
//7
//8
//string CurrentDirectory = System.Environment.CurrentDirectory;
//System.Environment.CurrentDirectory = CurrentDirectory + "\\Service";
//Process process = new Process();
//process.StartInfo.UseShellExecute = false;
//process.StartInfo.FileName = "Install.bat";
//process.StartInfo.CreateNoWindow = true;
//process.Start();
//System.Environment.CurrentDirectory = CurrentDirectory;
//2）卸载
//卸载时也会产生目录问题，所以卸载代码如下：
//1
//2
//3
//4
//5
//6
//7
//8
//string CurrentDirectory = System.Environment.CurrentDirectory;
//System.Environment.CurrentDirectory = CurrentDirectory + "\\Service";
//Process process = new Process();
//process.StartInfo.UseShellExecute = false;
//process.StartInfo.FileName = "Uninstall.bat";
//process.StartInfo.CreateNoWindow = true;
//process.Start();
//System.Environment.CurrentDirectory = CurrentDirectory;
//3）启动
//代码如下：
//1
//2
//3
//4
//5
//using System.ServiceProcess;
//ServiceController serviceController = new ServiceController("ServiceTest");
//serviceController.Start();
//4）停止
//1
//2
//3
//ServiceController serviceController = new ServiceController("ServiceTest");
//if (serviceController.CanStop)
//serviceController.Stop();
////5）暂停/继续
//        public void Parse()
//        {
//ServiceController serviceController = new ServiceController("ServiceTest");
//if (serviceController.CanPauseAndContinue)
//{
//if (serviceController.Status == ServiceControllerStatus.Running)
//serviceController.Pause();
//else if (serviceController.Status == ServiceControllerStatus.Paused)
//serviceController.Continue();
//}
//        }
////6）检查状态
//public string GetState()
//{
//ServiceController serviceController = new ServiceController("ServiceTest");
//string Status = serviceController.Status.ToString();
//    return Status;
//}
//    }
//}
