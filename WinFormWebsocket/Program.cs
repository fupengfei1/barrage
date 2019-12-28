using System;
using System.Windows.Forms;
using WebSocketClient;

namespace WinFormWebsocket
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

            //WSocketClient webClient = new WSocketClient("ws://122.51.83.109:11688/Chat");
            //webClient.Start();
            
            Application.Run(new Form1());
            //Application.Run(new Form3());
        }
    }
}
