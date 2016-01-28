using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DotNet_Utilities
{
    public class ProcessStart
    {
        public static void OpenFolder(string path)
        {
            Process.Start("explorer.exe", "/select, " + path);

        }
    }
}
