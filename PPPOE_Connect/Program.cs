using System;
using System.Windows.Forms;

namespace PPPOE_Connect
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool ret;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out ret);

            if (ret)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("程序已经在运行!");
                Application.Exit();
            }

            

        }
    }
}
