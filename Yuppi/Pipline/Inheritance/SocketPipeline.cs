using System.Threading;
using System.Threading.Tasks;
using Yuppi.Buffer.Interface;
using Yuppi.Delegates;
using Yuppi.Pipline.Interface;
using Yuppi.Serializer.Interface;

namespace Yuppi.Pipline.Inheritance
{
    public class SocketPipeLine<T> : IPipeline<T> where T : struct
    {
        public SocketPipeLine(ISocketSerializer<T> socketSerializer, IByteProvider byteProvider)
        {
            serializer = socketSerializer;
            provider = byteProvider;
        }
        private readonly IByteProvider provider;
        private readonly ISocketSerializer<T> serializer;
        public IByteProvider Provider => provider;
        public ISocketSerializer<T> Serializer => serializer;
        public void SendAnyData(T message)
        {
            byte[] byteArray = serializer.Serialize(message);

            provider.Write(byteArray);
        }
        public T WaitUntilComeAnyData()
        {
            byte[] byteArray = provider.Read();

            T message = serializer.Deserialize(byteArray);

            return message;
        }
        public Task AcceptNewSocket(AcceptSocket acceptSocket, CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew(@delegate =>
            {
                ((AcceptSocket)@delegate).Invoke(provider.Accept());
            }, acceptSocket, cancellationToken);
        }
    }
}