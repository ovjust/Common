using Cjwdev.WindowsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Ovjust.Common.App
{
    public class StartExt
    {
        int _currentAquariusProcessId;

         public void StartApp(string strAppPath)
        { 
            try 
           {
               IntPtr userTokenHandle = IntPtr.Zero; 
               ApiDefinitions.WTSQueryUserToken(ApiDefinitions.WTSGetActiveConsoleSessionId(), ref userTokenHandle);

               ApiDefinitions.PROCESS_INFORMATION procInfo = new ApiDefinitions.PROCESS_INFORMATION(); 
               ApiDefinitions.STARTUPINFO startInfo = new ApiDefinitions.STARTUPINFO(); 
               startInfo.cb = (uint)Marshal.SizeOf(startInfo);

               ApiDefinitions.CreateProcessAsUser( 
                   userTokenHandle, 
                   strAppPath, 
                 "", 
                   IntPtr.Zero, 
                   IntPtr.Zero, 
                   false, 
                   0, 
                   IntPtr.Zero, 
                   null, 
                   ref startInfo, 
                   out procInfo);

               if (userTokenHandle != IntPtr.Zero) 
                   ApiDefinitions.CloseHandle(userTokenHandle);

               _currentAquariusProcessId = (int)procInfo.dwProcessId; 
           } 
           catch (Exception ex) 
           { 
                //MessageBox.Show(ex.Message); 
           }
        }
    }
}
