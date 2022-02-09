using System.Net;
using System.Net.Sockets;
using System.Threading;
using Yuppi.Delegates;
using Yuppi.Environment;
using Yuppi.Networking.Abstract;
using Yuppi.Struct;

namespace Yuppi.Networking.Inheritance
{
    public class SocketServer : SocketNode
    {
        public SocketServer(IPEndPoint iPEndPoint, int bandwidth = Default.Bandwidth) : base(iPEndPoint, bandwidth)
        {
            identifier = new Identifier();

            identity = identifier.GetNewIdentity();

            clients = new KeyValueSync<uint, SocketClient>();
        }

        private readonly Identifier identifier;

        public KeyValueSync<uint, SocketClient> clients;
        public event OnAcceptDelegate OnAccept;
        public override event OnReceiveDelegate<P2PMessage> OnReceive;
        public override event OnLogDelegate OnLog;
        public void Start()
        {
            if (LogLevel.IsEnabled(LogType.Info))
                OnLog?.Invoke(this, "Start Server", Extensions.StackFrameDetail(), LogType.Info);

            pipeline.Provider.Socket.Bind(ipEndPoint);
            pipeline.Provider.Socket.Listen(100);

            thread = new Thread(HandleSocket);
            thread.Start();
        }

        private void HandleSocket()
        {
            Socket newSocket = pipeline.AcceptNewConnection();

            if (LogLevel.IsEnabled(LogType.Log))
                OnLog?.Invoke(this, string.Format("Handle new Socket. Ip : {0}", newSocket.RemoteEndPoint.ToString()), Extensions.StackFrameDetail(), LogType.Log);

            uint newIdentity = identifier.GetNewIdentity();

            SocketClient newClient = new SocketClient(newIdentity, newSocket);

            clients.Add(newIdentity, newClient);

            OnAccept?.Invoke(newClient);

            newClient.OnReceive += HandleClientReceive;

            newClient.ListenRemoteEndPoint();
        }

        private void HandleClientReceive(P2PMessage message)
        {
            if (LogLevel.IsEnabled(LogType.Info))
                OnLog?.Invoke(this, serializer.Serialize(message), Extensions.StackFrameDetail(), LogType.Info);

            if (IdentityCheck(message.source))
                OnReceive?.Invoke(message);
        }

        private bool IdentityCheck(uint id)
        {
            if (!identifier.IsCorrect(id))
                return false;

            foreach (SpecialId specialId in identifier.specialIdList)
            {
                if ((uint)specialId == id)
                    return true;
            }

            if (clients.Has(id))
                return true;

            return false;
        }
    }
}