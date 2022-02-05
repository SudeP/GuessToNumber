using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessToNumber.Gateway
{
    public abstract class Yuppi : ISocket, IDisposable
    {
        internal Yuppi(IPEndPoint ipEndPoint, Encoding encoding)
        {
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
        private ConcurrentDictionary<uint, CancellationTokenSource> receiveHandleTaskCancellationTokenSources;
        private ConcurrentDictionary<uint, Task> receiveHandleTasks;

        public virtual void Start()
        {
            receiveHandleTaskCancellationTokenSources = new ConcurrentDictionary<uint, CancellationTokenSource>();
            receiveHandleTasks = new ConcurrentDictionary<uint, Task>();
            SocketCreate();
            Send = new YuppiPipeLine(this);
        }

        public virtual void Stop()
        {
            DestorySocket(Pipline);

            if (receiveHandleTaskCancellationTokenSources != null)
                foreach (var source in receiveHandleTaskCancellationTokenSources)
                    if (source.Value != null && !source.Value.IsCancellationRequested)
                    {
                        source.Value.Cancel(false);
                        source.Value.Dispose();
                    }

            if (receiveHandleTaskCancellationTokenSources != null)
            {
                receiveHandleTaskCancellationTokenSources.Clear();
                receiveHandleTaskCancellationTokenSources = null;
            }
            if (receiveHandleTasks != null)
            {
                receiveHandleTasks.Clear();
                receiveHandleTasks = null;
            }

            GC.Collect();
            GC.SuppressFinalize(this);
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

            if (receiveHandleTaskCancellationTokenSources.TryAdd(id, cancellationTokenSource))
            {
                Task receiveHandleTask = new Task(ReceiveHandle, socket, cancellationTokenSource.Token);

                if (receiveHandleTasks.TryAdd(id, receiveHandleTask))
                    receiveHandleTask.Start();
            }
            else
                OnLog?.Invoke("Receive listener not be create, Thread Exception.", "StartListen", true);
        }

        private void ReceiveHandle(object socketObject)
        {
            YuppiSocket pipeLine = socketObject as YuppiSocket;

            while (IsSocketConnected())
            {
                try
                {
                    string jsonText = string.Empty;

                    do
                    {
                        byte[] buffer = new byte[1024];

                        pipeLine.Socket.Receive(buffer, 0, buffer.Length, SocketFlags.None);

                        jsonText += buffer.ToString(Encoding);

                    } while (pipeLine.Socket.Available > 0);

                    if (jsonText.JsonObject(out SocketData socketData))
                        OnRecieveListen?.Invoke(socketData, pipeLine);
                }
                catch (Exception ex)
                {
                    OnLog?.Invoke(ex.Message, "ReceiveHandle", true);
                }
            }
            if (IsClient)
                Stop();
            else
                DestorySocket(pipeLine);
        }

        protected void DestorySocket(YuppiSocket trash)
        {
            try
            {
                if (trash != null)
                {
                    if (trash.Socket.Connected)
                        trash.Socket.Disconnect(false);

                    trash.Socket.Dispose();
                }
            }
            catch (Exception ex)
            {
                OnLog?.Invoke(ex.Message, "IsSocketConnected", true);
            }
        }

        protected bool IsSocketConnected()
        {
            try
            {
                bool part1 = Pipline.Socket.Poll(1000, SelectMode.SelectRead);
                bool part2 = (Pipline.Socket.Available == 0);
                if (part1 && part2)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                OnLog?.Invoke(ex.Message, "IsSocketConnected", true);
                return false;
            }
        }

        public void Dispose()
        {
            Stop();

            GC.Collect();
            GC.SuppressFinalize(this);
        }
    }
}