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

            while (count < 3)
            {

                try
                {
                    //切换为搜狐的ip
                    HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create("http://pv.sohu.com/cityjson");
                    hwr.Timeout = 3000;
                    hwr.KeepAlive = false;
                    HttpWebResponse hwrs = (HttpWebResponse)hwr.GetResponse();
                    Stream s = hwrs.GetResponseStream();
                    StreamReader sr = new StreamReader(s, Encoding.Default);
                    all = sr.ReadToEnd(); //读取网站的数据
                    int start = all.IndexOf("cip") +7;
                    int end = all.IndexOf("\",", start);
                    var tempip = all.Substring(start, end - start);
                    hwr.Abort();
                    hwrs.Close();
                    sr.Close();

                    return tempip;
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
