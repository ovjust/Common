using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Ovjust.DbXpoProvider
{
    public class XpoLogWriterTextFile : TraceListener
    {
        string fileName = "log.txt";
        FileStream fs;
        StreamWriter sw;
        public XpoLogWriterTextFile()
        {
            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
             fs=  File.Open(fileName, FileMode.OpenOrCreate,FileAccess.ReadWrite);
             sw = new StreamWriter(fs);
        }
        public override void Write(string message)
        {
            sw.Write(message); 
            sw.Flush();
            sw.Close();
        }
        public override void WriteLine(string message)
        {
            sw.WriteLine(message);
            sw.Flush();
            sw.Close();
        }
    }
}
