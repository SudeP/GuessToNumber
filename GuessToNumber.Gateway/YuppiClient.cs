using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GuessToNumber.Gateway
{
    public class YuppiClient : Yuppi
    {
        public YuppiClient(IPEndPoint iPEndPoint, Encoding encoding) : base(iPEndPoint, encoding)
        {
            IsClient = true;
        }

        public override event YuppiLogHandler OnLog;
        public event RecieveClientHandler OnRecieveClient;
        public string AuthorizationKey { get; set; }
        public override void Start()
        {
            OnRecieveListen += YuppiClient_OnHandleRecieve;

            base.Start();

            Task.Factory.StartNew(() =>
            {
                if (HandleClientId())
                    return;

                StartListen(Id, Pipline);
            });
        }
        public override void Stop()
        {
            base.Stop();

            OnRecieveListen -= YuppiClient_OnHandleRecieve;
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

        public void JoinLobby(string authorizationKey)
        {
            if (ControlAny(authorizationKey))
                return;

            Pipline.Socket.Send(new SocketData(Id, SpecificIdentity.JoinLobby, authorizationKey).JsonString().ToByteArray(Encoding));
        }

        private bool ControlAny(string authorizationKey)
        {
            if (Id == 0)
            {
                OnLog?.Invoke("Id is null. Firstly call Start method", "ControlAny", true);
                return true;
            }

            if (string.IsNullOrEmpty(authorizationKey) || string.IsNullOrWhiteSpace(authorizationKey))
            {
                OnLog?.Invoke("'authorizationKey' is null. not be null", "ControlAny", true);
                return true;
            }

            AuthorizationKey = authorizationKey;
            return false;
        }

        private void YuppiClient_OnHandleRecieve(SocketData socketData, YuppiSocket handledSocket)
        {
            OnRecieveClient?.Invoke(socketData);
        }

        private bool HandleClientId()
        {

            byte[] buffer = new byte[uint.MaxValue.ToString().ToByteArray(Encoding).Length];

            Pipline.Socket.Receive(buffer);

            if (byte.TryParse(buffer.ToString(Encoding), out byte clientId))
            {
                Id = clientId;
                Pipline.Id = Id;

                Pipline.Socket.Send(clientId.ToString().ToByteArray(Encoding));

                return false;
            }
            else
            {
                OnLog?.Invoke("Handle socket error [server didn't give id to client]", "HandleClientId", true);

                return true;
            }
        }
    }
}
