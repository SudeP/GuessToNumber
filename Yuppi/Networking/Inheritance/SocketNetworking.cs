using Yuppi.Buffer.Inheritance;
using Yuppi.Pipline.Inheritance;
using Yuppi.Pipline.Interface;
using Yuppi.Serializer.Inheritance;

namespace Yuppi.Networking.Inheritance
{
    public class SocketNetworking<T> where T : struct
    {
        public SocketNetworking(IPipeline<T> pipline)
        {
            new SocketPipeLine<T>(new BinarySocketSerializer<T>(), new StreamByteProvider(new System.Net.Sockets.Socket(default)));
            Pipline = pipline;
        }
        public IPipeline<T> Pipline { get; set; }
    }
}