using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace GrechkaServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Grechka Server";

            ChatServer.Run(50, 8080);
        }
    }
}
