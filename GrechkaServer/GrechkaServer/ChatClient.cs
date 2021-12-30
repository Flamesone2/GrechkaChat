using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GrechkaServer
{
    class ChatClient
    {
        public static int dataBufferSize = 4096;

        public int id;
        public TCP tcp;

        public ChatClient(int _clientId)
        {
            id = _clientId;
            tcp = new TCP(id);
        }

        public class TCP
        {
            public TcpClient socket;

            private NetworkStream stream;
            private readonly int id;
            private byte[] reciveBuffer;

            public TCP(int _id)
            {
                id = _id;
            }

            public void Connect(TcpClient _socket)
            {
                socket = _socket;
                socket.ReceiveBufferSize = dataBufferSize;
                socket.SendBufferSize = dataBufferSize;

                stream = socket.GetStream();

                reciveBuffer = new byte[dataBufferSize];

                stream.BeginRead(reciveBuffer, 0, dataBufferSize, ReciveCallBack, null);

            }

            private void ReciveCallBack(IAsyncResult _result)
            {
                try
                {
                    int _byteLength = stream.EndRead(_result);
                    if (_byteLength <= 0)
                    {
                        return;
                    }

                    byte[] _data = new byte[_byteLength];
                    Array.Copy(reciveBuffer, _data, _byteLength);

                    stream.BeginRead(reciveBuffer, 0, dataBufferSize, ReciveCallBack, null);
                }
                catch (Exception _ex)
                {

                }
            }
        }
    }
}