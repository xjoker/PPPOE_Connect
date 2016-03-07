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
                Thread.Sleep(1000);
                try
                {
                    WebRequest wr = WebRequest.Create("http://www.ip138.com/ips138.asp");
                    Stream s = wr.GetResponse().GetResponseStream();
                    StreamReader sr = new StreamReader(s, Encoding.Default);
                    all = sr.ReadToEnd(); //读取网站的数据

                    int start = all.IndexOf("您的IP地址是：[") + 9;
                    int end = all.IndexOf("]", start);
                    tempip = all.Substring(start, end - start);
                    sr.Close();

                    //Console.WriteLine("get_ip: " + count);
                    /////截取网站数据
                    /////数据范例 ：您的IP是：[122.228.229.21] 来自：浙江省温州市 电信
                    ///// 
                    //Console.WriteLine("-------web----read---start--");
                    //WebRequest wr = WebRequest.Create("http://ident.me/");

                    //wr.Timeout = 5000;
                    //Stream s = wr.GetResponse().GetResponseStream();
                    //StreamReader sr = new StreamReader(s, Encoding.Default);
                    //all = sr.ReadToEnd(); //读取网站的数据
                    //Console.WriteLine("-------web----read-------");
                    return tempip;
                }
                catch
                {
                    count++;

                }
            }
            return all = "获取失败!";
        }
    }
}
