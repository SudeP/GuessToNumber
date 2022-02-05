using System.Net;
using System.Text;

namespace GuessToNumber.Gateway
{
    public interface ISocket
    {
        IPEndPoint IpEndPoint { get; internal set; }
        Encoding Encoding { get; internal set; }
        bool IsClient { get; internal set; }
        uint Id { get; internal set; }
    }
}
