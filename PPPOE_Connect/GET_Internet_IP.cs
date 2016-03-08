using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace PPPOE_Connect
{
    class GET_Internet_IP
    {
        private string tempip;

        public string GetIP()
        {
            string all = null;
            int count = 0;
            while (count < 3)
            {
                Thread.Sleep(100);
                try
                {
                    WebRequest wr = WebRequest.Create("http://www.ip138.com/ips138.asp");
                    //加速获取IP的速率
                    wr.Proxy = null;
                    wr.Timeout = 3000;
                    Stream s = wr.GetResponse().GetResponseStream();
                    StreamReader sr = new StreamReader(s, Encoding.Default);
                    all = sr.ReadToEnd(); //读取网站的数据

                    int start = all.IndexOf("您的IP地址是：[") + 9;
                    int end = all.IndexOf("]", start);
                    tempip = all.Substring(start, end - start);
                    sr.Close();
                    return tempip;
                }
                catch
                {
                    count++;
                    Logging.Error("获取公网IP失败，尝试次数：" + count);
                }
            }
            return all = "获取失败!";
        }
    }
}
