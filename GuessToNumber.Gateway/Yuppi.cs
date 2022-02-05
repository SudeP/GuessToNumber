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
        public YuppiSocket Pipline { get; protected set; }
        public virtual event YuppiLogHandler OnLog;
        protected event RecieveListenHandler OnRecieveListen;
        private readonly ConcurrentDictionary<uint, CancellationTokenSource> receiveHandleTasks;

        public virtual void Start()
        {
            SocketCreate();
        }

        public virtual void Stop()
        {
            DestorySocket(Pipline);

            if (receiveHandleTasks != null)
                foreach (var task in receiveHandleTasks)
                    if (task.Value != null && task.Value.IsCancellationRequested)
                        task.Value.Cancel(false);
        }

        protected void SocketCreate()
        {
            Pipline = new YuppiSocket(SocketType.Stream, ProtocolType.Tcp);

            if (IsClient)
                Pipline.Socket.Connect(IpEndPoint);
            else
            {
                Pipline.Socket.Bind(IpEndPoint);
                Pipline.Socket.Listen(100);
            }
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
                OnLog?.Invoke("Receive listener not be create, Thread Exception.", "StartListen", true);
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

                    socket.Socket.Receive(buffer, 0, buffer.Length, SocketFlags.None);

                    jsonText += buffer.ToString(Encoding);

                } while (socket.Socket.Available > 0);

                if (jsonText.JsonObject(out SocketData socketData))
                    OnRecieveListen?.Invoke(socketData, socket);
            }
        }

        protected void DestorySocket(YuppiSocket trash)
        {
            if (trash != null)
            {
                if (trash.Socket.Connected)
                    trash.Socket.Disconnect(false);

                trash.Socket.Dispose();
            }
        }

        protected bool IsSocketConnected()
        {
            bool part1 = Pipline.Socket.Poll(1000, SelectMode.SelectRead);
            bool part2 = (Pipline.Socket.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }
    }
}