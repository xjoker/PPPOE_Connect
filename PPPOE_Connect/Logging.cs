using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPPOE_Connect
{
    class Logging
    {
        public static string LogFilePath;

        public static bool OpenLogFile()
        {

            try
            {
                LogFilePath = Path.Combine(Application.StartupPath, "xlqh.log");

                //限制日志文件不大于30KB
                if (File.Exists(LogFilePath))
                {
                    FileInfo fi = new FileInfo(LogFilePath);
                    if (fi.Length>30000)
                    {
                        File.Delete(LogFilePath);
                    }
                }


                FileStream fs = new FileStream(LogFilePath, FileMode.Append);
                StreamWriterWithTimestamp sw = new StreamWriterWithTimestamp(fs);
                sw.AutoFlush = true;
                Console.SetOut(sw);
                Console.SetError(sw);

                return true;
            }
            catch 
            {
                return false;
            }
        }

        private static void WriteToLogFile(object o)
        {
            Console.WriteLine(o);
        }

        public static void Error(object o)
        {
            WriteToLogFile("[E] " + o);
        }

        public static void Info(object o)
        {
            WriteToLogFile(o);
        }
    }

    public class StreamWriterWithTimestamp : StreamWriter
    {
        public StreamWriterWithTimestamp(Stream stream) : base(stream)
        {
        }

        private string GetTimestamp()
        {
            return "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] ";
        }

        public override void WriteLine(string value)
        {
            base.WriteLine(GetTimestamp() + value);
        }

        public override void Write(string value)
        {
            base.Write(GetTimestamp() + value);
        }
    }
}
