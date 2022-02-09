using System;
using System.Net;
using Yuppi.Delegates;
using Yuppi.Environment;
using Yuppi.Networking.Abstract;
using Yuppi.Networking.Inheritance;
using Yuppi.Struct;

namespace Yuppi.Manager.SocketLobbyManagement
{
    public class SocketLobbyUser
    {
        public SocketLobbyUser(IPAddress ipAddress, int port)
        {
            client = new SocketClient(new IPEndPoint(ipAddress, port));

            client.OnReceive += Client_OnReceive;

            client.OnLog += SocketOnLog;
        }

        public readonly SocketClient client;

        public event OnLogDelegate OnLog;

        public event OnReceiveDelegate<P2PMessage> OnReceive;

        public void Start()
        {
            if (HandleClientId())
                return;

            client.ListenRemoteEndPoint();
        }

        private void SocketOnLog(object sender, string message, string stackTrace, LogType type)
        {
            OnLog?.Invoke(sender, string.Format("{0} : {1}", ((SocketNode)sender).Identity, message), stackTrace, type);
        }

        private void Client_OnReceive(P2PMessage request)
        {
            OnReceive?.Invoke(request);
        }

        private bool HandleClientId()
        {

            byte[] buffer = client.pipeline.Provider.Write();

            uint.Parse()

            if (byte.TryParse(buffer.ToString(Encoding), out byte clientId))
            {
                Id = clientId;
                Pipline.Id = Id;

                Pipline.Socket.Send(clientId.ToString().ToByteArray(Encoding));

                return false;
            }
            else
            {
                OnLog?.Invoke("Handle socket error [server didn't give id to client]", "HandleClientId", true);

                return true;
            }
        }
    }
}
