using System.Net.Sockets;

namespace GuessToNumber.Gateway
{
    public class YuppiSocket : Socket
    {
        public uint Id { get; set; }
        public string AuthorizationKey { get; set; }
        public YuppiSocket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) : base(addressFamily, socketType, protocolType)
        {

        }
    }
}