using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Yuppi.Delegates;
using Yuppi.Environment;
using Yuppi.Pipeline.Inheritance;
using Yuppi.Struct;

namespace Yuppi.Networking.Abstract
{
    public abstract class SocketNode : IDisposable
    {
        public SocketNode(uint determinedIdentity, Socket createdSocket)
        {
            identity = determinedIdentity;

            ipEndPoint = (IPEndPoint)createdSocket.RemoteEndPoint;

            pipeline = SocketPipeLine.Instace(createdSocket);

            serializer = new JSONSerializer();
        }

        public SocketNode(IPEndPoint iPEndPoint)
        {
            ipEndPoint = iPEndPoint;

            pipeline = SocketPipeLine.Instace();

            serializer = new JSONSerializer();
        }

        public SocketNode(IPEndPoint iPEndPoint, int bandwidth)
        {
            ipEndPoint = iPEndPoint;

            pipeline = SocketPipeLine.Instace(bandwidth: bandwidth);

            serializer = new JSONSerializer();
        }

        protected uint identity;
        protected Thread thread;


        public readonly IPEndPoint ipEndPoint;
        public readonly SocketPipeLine pipeline;
        public readonly JSONSerializer serializer;

        public uint Identity => identity;

        public virtual event OnReceiveDelegate<P2PMessage> OnReceive;
        public virtual event OnLogDelegate OnLog;

        public void ListenRemoteEndPoint()
        {
            if (LogLevel.IsEnabled(LogType.Info))
                OnLog?.Invoke(this, "Start ListenRemoteEndPoint()", Extensions.StackFrameDetail(), LogType.Info);

            thread = new Thread(new ParameterizedThreadStart(HandleReceive));

            thread.Start(pipeline);
        }

        public void Send(P2PMessage message)
        {
            if (LogLevel.IsEnabled(LogType.Info))
                OnLog?.Invoke(this, "Send Message", Extensions.StackFrameDetail(), LogType.Info);

            pipeline.SendAnyData(message);
        }

        private void HandleReceive(object @object)
        {
            SocketPipeLine pipeline = (SocketPipeLine)@object;

            P2PMessage handledMessage = pipeline.WaitUntilComeAnyData();

            if (LogLevel.IsEnabled(LogType.Info))
                OnLog?.Invoke(this, "Handle new message", Extensions.StackFrameDetail(), LogType.Info);

            OnReceive?.Invoke(handledMessage);
        }

        public virtual void Dispose()
        {
            pipeline.Disconnect();

            if (thread != null)
            {
                thread.Abort();
                thread = null;
            }
        }
    }
}
