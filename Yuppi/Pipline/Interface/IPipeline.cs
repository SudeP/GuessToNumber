using System.Net.Sockets;
using Yuppi.Struct;

namespace Yuppi.Pipline.Interface
{
    public interface IPipeline<T> where T : struct
    {
        public void SendAnyData(T message);
        public T WaitUntilComeAnyData();
    }
}