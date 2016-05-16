using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace PPPOE_Connect
{
    class GET_Internet_IP
    {

        public string GetIP()
        {
            string all = null;
            int count = 0;
            //刷新DNS缓存
            using (System.Diagnostics.Process process = new System.Diagnostics.Process())
            {
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "ipconfig /flushdns";
                process.StartInfo = startInfo;
                process.Start();
            }
            while (count < 3)
            {

                try
                {
                    HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create("https://xjoker.us/getip.php");
                    hwr.Timeout = 5000;
                    hwr.KeepAlive = false;
                    HttpWebResponse hwrs = (HttpWebResponse)hwr.GetResponse();
                    Stream s = hwrs.GetResponseStream();
                    StreamReader sr = new StreamReader(s, Encoding.Default);
                    all = sr.ReadToEnd(); //读取网站的数据
                    hwr.Abort();
                    hwrs.Close();
                    sr.Close();

                    return all;
                }
                catch (System.Exception e)
                {
                    count++;
                    Logging.Error("获取公网IP失败，尝试次数：" + count);
                    Logging.Error(e);
                }
            }
            return all = "获取失败!";
        }
    }
}
