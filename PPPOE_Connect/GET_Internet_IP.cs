using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                Thread.Sleep(500);
                try
                {
                    Console.WriteLine("get_ip: " + count);
                    ///截取网站数据
                    ///数据范例 ：您的IP是：[122.228.229.21] 来自：浙江省温州市 电信
                    /// 
                    Console.WriteLine("-------web----read---start--");
                    WebRequest wr = WebRequest.Create("http://ident.me/");

                    wr.Timeout = 5000;
                    Stream s = wr.GetResponse().GetResponseStream();
                    StreamReader sr = new StreamReader(s, Encoding.Default);
                    all = sr.ReadToEnd(); //读取网站的数据
                    Console.WriteLine("-------web----read-------");
                    return all;
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
