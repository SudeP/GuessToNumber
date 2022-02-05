using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessToNumber.Gateway
{
    public abstract class Yuppi : ISocket
    {
        internal Yuppi(IPEndPoint ipEndPoint, Encoding encoding)
        {
            Send = new YuppiPipeLine(this);
            receiveHandleTasks = new ConcurrentDictionary<uint, CancellationTokenSource>();
            IpEndPoint = ipEndPoint;
            Encoding = encoding;
        }

        ~Yuppi()
        {
            Stop();
        }

        IPEndPoint ISocket.IpEndPoint { get; set; }
        Encoding ISocket.Encoding { get; set; }
        bool ISocket.IsClient { get; set; }
        uint ISocket.Id { get; set; }

        public IPEndPoint IpEndPoint
        {
            get
            {
                return ((ISocket)this).IpEndPoint;
            }
            internal set
            {
                ((ISocket)this).IpEndPoint = value;
            }
        }

        public Encoding Encoding
        {
            get
            {
                return ((ISocket)this).Encoding;
            }
            internal set
            {
                ((ISocket)this).Encoding = value;
            }
        }

        public bool IsClient
        {
            get
            {
                return ((ISocket)this).IsClient;
            }
            internal set
            {
                ((ISocket)this).IsClient = value;
            }
        }

        public uint Id
        {
            get
            {
                return ((ISocket)this).Id;
            }
            internal set
            {
                ((ISocket)this).Id = value;
            }
        }

        public YuppiPipeLine Send { get; protected set; }
        public YuppiSocket Socket { get; protected set; }
        protected event RecieveListenHandler OnRecieveListen;
        private readonly ConcurrentDictionary<uint, CancellationTokenSource> receiveHandleTasks;

        public virtual void Start()
        {
            SocketCreate();
        }

        protected virtual void Stop()
        {
            DestorySocket(Socket);

            if (receiveHandleTasks != null)
                foreach (var task in receiveHandleTasks)
                    if (task.Value != null && task.Value.IsCancellationRequested)
                        task.Value.Cancel(false);
        }

        protected void SocketCreate()
        {
            Socket = new YuppiSocket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Socket.Connect(IpEndPoint);
        }

        protected void StartListen(uint id, YuppiSocket socket)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            if (receiveHandleTasks.TryAdd(id, cancellationTokenSource))
            {
                Task receiveHandleTask = new Task(ReceiveHandle, socket, cancellationTokenSource.Token);

                receiveHandleTask.Start();
            }
            else
                throw new InvalidOperationException("Receive listener not be create, Thread Exception.");
        }

        private void ReceiveHandle(object socketObject)
        {
            YuppiSocket socket = socketObject as YuppiSocket;

            while (IsSocketConnected())
            {
                string jsonText = string.Empty;

                do
                {
                    byte[] buffer = new byte[1024];

                    socket.Receive(buffer, 0, buffer.Length, SocketFlags.None);

                    jsonText += buffer.ToString(Encoding);

                } while (socket.Available > 0);

                if (jsonText.JsonObject(out SocketData socketData))
                    OnRecieveListen?.Invoke(socketData, socket);
            }
        }

        protected void DestorySocket(YuppiSocket trash)
        {
            if (trash != null)
            {
                if (trash.Connected)
                    trash.Disconnect(false);

                trash.Dispose();
            }
        }

        protected bool IsSocketConnected() => !((Socket.Poll(1000, SelectMode.SelectRead) && (Socket.Available == 0)) || !Socket.Connected);
    }
}