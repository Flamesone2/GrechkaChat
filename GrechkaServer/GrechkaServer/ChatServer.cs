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
        public Dictionary<int, Client> clients = new Dictionary<int, Client>();

        private static TcpListener tcpListener { get; set; }
        public static int  maxClients { get; private set; }

        public static int port { get; private set; }
        public static void Run(int _maxClients, int _port)
        {
            
            const string ip = "127.0.0.1";

            maxClients = _maxClients;
            port = _port;

            InitialiseServerData();

            tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPConnectCallback), null);

        }

        private static void TCPConnectCallback(IAsyncResult _result)
        {
            TcpClient _client = tcpListener.EndAcceptTcpClient(_result);
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPConnectCallback), null);

            for (int i = 0; i <= maxClients; i++)
            {
                if(clients[i].tcp.socket == null)
                {
                    maxClients[i].tcp.Connect(_client);
                    return;
                }
            }
        }

        private static void InitialiseServerData()
        {
            for (int i = 1; i <= maxClients; i++)
            {
                clients.Add(i, new Clients);
            }
        }

    }
}
