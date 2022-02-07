using System.Net.Sockets;

namespace Yuppi.Buffer.Interface
{
    public interface IByteProvider
    {
        Socket Socket { get; }
        int Bandwidth { get; }
        public void Write(byte[] buffer);
        public byte[] Read();
        public Socket Accept();
    }
}