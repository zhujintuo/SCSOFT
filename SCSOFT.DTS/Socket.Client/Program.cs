using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Socket.Client
{
    class Program
    {
        private static byte[] result = new byte[1024];
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("10.41.100.81");
            System.Net.Sockets.Socket clientSocket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(ip, 8009));
                Console.WriteLine("连接服务器成功");
            }
            catch (Exception ex)
            {
                Console.WriteLine("连接服务器失败，请按回车键退出！");
                return;
            }

            int receiveLength = clientSocket.Receive(result);
            Console.WriteLine("接收服务器消息：{0}", Encoding.ASCII.GetString(result, 0, receiveLength));

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Thread.Sleep(1000);
                    string sendMessage = "client send Message Hello " + DateTime.Now;
                    clientSocket.Send(Encoding.ASCII.GetBytes(sendMessage));
                    Console.WriteLine("向服务器发送消息：{0}" , sendMessage);
                }
                catch (Exception ex)
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    break;
                }
            }

            Console.WriteLine("发送完毕，按回车键退出");
            Console.ReadLine();
        }
    }
}
