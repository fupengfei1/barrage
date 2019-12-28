using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WSocketClient client = new WSocketClient("ws://106.54.91.245:11688/lcj控制台"); 
            //注册消息接收事件，接收服务端发送的数据
            client.MessageReceived += (data) => {
                Console.WriteLine(data);
            };
            //开始链接
            client.Start();

            Console.WriteLine("输入“c”，退出");
            var input = "";
            do
            {
                input = Console.ReadLine();
                //客户端发送消息到服务端
                client.SendMessage(input);
            } while (input != "c");
            client.Dispose();
        }
    }
}
