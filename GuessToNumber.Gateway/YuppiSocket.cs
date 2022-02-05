using System.Net.Sockets;

namespace GuessToNumber.Gateway
{
    public class YuppiSocket
    {
        public uint Id { get; set; }
        public string AuthorizationKey { get; set; }
        public Socket Socket { get; set; }
        public YuppiSocket(Socket socket)
        {
            Socket = socket;
        }
        public YuppiSocket(SocketType socketType, ProtocolType protocolType)
        {
            Socket = new Socket(socketType, protocolType);
        }
    }
}