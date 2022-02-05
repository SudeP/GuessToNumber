using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace GuessToNumber.Gateway
{
    public class YuppiClient : Yuppi
    {
        public YuppiClient(IPEndPoint iPEndPoint, Encoding encoding) : base(iPEndPoint, encoding)
        {

            OnRecieveListen += YuppiClient_OnHandleRecieve;
        }

        public event RecieveClientHandler OnRecieveClient;
        public string AuthorizationKey { get; set; }

        public override void Start()
        {
            base.Start();

            HandleClientId();

            StartListen(Id, Socket);
        }

        public void CreateLobby(LobbySettings lobbySettings)
        {
            ControlAny(lobbySettings.AuthorizationKey);

            if (lobbySettings.Capacity <= 0)
                throw new Exception("Please bro. Capacity greater from ZERO, okkey!.");

            Socket.Send(new SocketData(Id, SpecificIdentity.CreateLobby, lobbySettings).JsonString().ToByteArray(Encoding));
        }

        public void JoinLobby(string authorizationKey)
        {
            ControlAny(authorizationKey);

            Socket.Send(new SocketData(Id, SpecificIdentity.JoinLobby, authorizationKey).JsonString().ToByteArray(Encoding));
        }

        private void ControlAny(string authorizationKey)
        {
            if (Id == 0)
                throw new Exception("Id is null. Firstly call Start method");

            if (string.IsNullOrEmpty(authorizationKey) || string.IsNullOrWhiteSpace(authorizationKey))
                throw new ArgumentNullException("authorizationKey");

            AuthorizationKey = authorizationKey;
        }

        private void YuppiClient_OnHandleRecieve(SocketData socketData, Socket handledSocket)
        {
                OnRecieveClient?.Invoke(socketData);
        }

        private void HandleClientId()
        {

            byte[] buffer = new byte[uint.MaxValue.ToString().ToByteArray(Encoding).Length];

            Socket.Receive(buffer);

            if (byte.TryParse(buffer.ToString(Encoding), out byte clientId))
            {
                Id = clientId;
                Socket.Id = Id;

                Socket.Send(clientId.ToString().ToByteArray(Encoding));
            }
            else
                throw new Exception("Handle socket error [server didn't give id to client]");
        }
    }
}
