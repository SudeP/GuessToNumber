using System.Net;
using System.Net.Sockets;
using Yuppi.Networking.Abstract;

namespace Yuppi.Networking.Inheritance
{
    public class SocketClient : SocketNode
    {
        internal SocketClient(uint determinedIdentity, Socket createdSocket) : base(determinedIdentity, createdSocket)
        {

        }

        public SocketClient(IPEndPoint iPEndPoint) : base(iPEndPoint)
        {

        }

        public SocketClient(IPAddress ipAddress, int port) : base(new IPEndPoint(ipAddress, port))
        {

        }

        public void CreateLobby(LobbySettings lobbySettings)
        {
            if (ControlAny(lobbySettings.AuthorizationKey))
                return;

            if (lobbySettings.Capacity <= 0)
            {
                OnLog?.Invoke("Please bro. Capacity greater from ZERO, okkey!.", "CreateLobby", true);
                return;
            }

            Pipline.Socket.Send(new SocketData(Id, SpecificIdentity.CreateLobby, lobbySettings).JsonString().ToByteArray(Encoding));
        }

    }
}