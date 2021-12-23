using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace GrechkaServer
{
    class Program
    {
        public List<IPEndPoint> ips { get; set; }

        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8080;


            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(5);

            List<IPEndPoint> ips = new List<IPEndPoint>();
            ips.Add(tcpEndPoint);

            while (true)
            {
                var listener = tcpSocket.Accept();
                var buffer = new byte[256];
                var size = 0;
                var data = new StringBuilder();

                do
                {
                    size = listener.Receive(buffer);
                    data.Append(Encoding.UTF8.GetString(buffer, 0, size));

                }
                while (listener.Available > 0);

                listener.Shutdown(SocketShutdown.Both);

                for (int i = 0; i< ips.Count; i++)
                {

                    
                }


                Console.WriteLine(data.ToString());

                listener.Send(Encoding.UTF8.GetBytes(data.ToString()));

                
                listener.Close();
                listener.Shutdown(SocketShutdown.Both);
            }
        }
    }
}
