﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GrechkaChat
{
    class Network
    {

        public string message { get; private set; }
        public string answer { get; private set; }
        

        public void StartConection(Message mesObj)
        {
            const string ip = "127.0.0.1";
            const int port = 8080;


            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            this.message = $"{mesObj.sender} : {mesObj.message_context}";

            var data = Encoding.UTF8.GetBytes(message);

            tcpSocket.Connect(tcpEndPoint);
            tcpSocket.Send(data);

            var buffer = new byte[256];
            var size = 0;
            var answer = new StringBuilder();

            do
            {
                size = tcpSocket.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));

            }
            while (tcpSocket.Available > 0);

            this.answer = answer.ToString();

            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();

        }
    }
}
