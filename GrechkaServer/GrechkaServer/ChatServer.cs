using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GrechkaServer
{
    class ChatServer
    {
        public List<IPEndPoint> ips { get; set; }

        private static TcpListener tcpListener { get; set; }
        public int maxClients { get; private set; }



        public int port { get; private set; }
        public void Run(int _maxClients, int _port)
        {
            
            const string ip = "127.0.0.1";

            maxClients = _maxClients;
            port = _port;

            tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPConnectCallback), null);

        }

        private static void TCPConnectCallback(IAsyncResult _result)
        {
            TcpClient _client = tcpListener.EndAcceptTcpClient(_result);
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPConnectCallback), null);
        }

    }
}
