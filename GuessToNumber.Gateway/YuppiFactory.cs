using System.Net;
using System.Text;

namespace GuessToNumber.Gateway
{
    public static class YuppiFactory
    {
        public static YuppiClient Client(IPEndPoint iPEndPoint, Encoding encoding) => new YuppiClient(iPEndPoint, encoding);
        public static YuppiServer Server(IPEndPoint iPEndPoint, Encoding encoding) => new YuppiServer(iPEndPoint, encoding);
    }
}
