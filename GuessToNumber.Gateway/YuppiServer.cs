using System.Collections.Concurrent;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessToNumber.Gateway
{
    public class YuppiServer : Yuppi
    {
        public YuppiServer(IPEndPoint iPEndPoint, Encoding encoding) : base(iPEndPoint, encoding)
        {
            lobbies = new ConcurrentDictionary<string, YuppiLobby>();
            sockets = new ConcurrentDictionary<uint, YuppiSocket>();
            OnRecieveListen += YuppiServer_OnHandleRecieve;
        }

        ~YuppiServer()
        {
            Stop();
        }

        public event RecieveServerHandler OnRecieveServer;
        private uint identity = SpecificIdentity.IdentitySeed;
        private Task acceptHandleTask;
        private CancellationTokenSource acceptHandleTaskCancellationTokenSource;
        private readonly ConcurrentDictionary<string, YuppiLobby> lobbies;
        private readonly ConcurrentDictionary<uint, YuppiSocket> sockets;

        public new void Stop()
        {
            if (acceptHandleTaskCancellationTokenSource != null && acceptHandleTaskCancellationTokenSource.IsCancellationRequested)
                acceptHandleTaskCancellationTokenSource.Cancel(false);

            base.Stop();
        }

        public override void Start()
        {
            base.Start();

            Id = GetNewIdentity();
            Socket.Id = Id;

            acceptHandleTaskCancellationTokenSource = new CancellationTokenSource();

            acceptHandleTask = new Task(AcceptHandle, acceptHandleTaskCancellationTokenSource.Token);

            acceptHandleTask.Start();
        }

        private void AcceptHandle()
        {
            while (true)
            {
                YuppiSocket newClientSocket = Socket.Accept() as YuppiSocket;

                var newIdentity = GetNewIdentity();
                newClientSocket.Id = newIdentity;

                newClientSocket.Send(newIdentity.ToString().ToByteArray(Encoding));

                byte[] buffer = new byte[uint.MaxValue.ToString().ToByteArray(Encoding).Length];

                newClientSocket.Receive(buffer);


                if (byte.TryParse(buffer.ToString(Encoding), out byte clientId))
                    if (newIdentity == clientId)
                        if (sockets.TryAdd(clientId, newClientSocket))
                        {
                            StartListen(clientId, newClientSocket);

                            continue;
                        }

                DestorySocket(newClientSocket);
            }
        }

        private void YuppiServer_OnHandleRecieve(SocketData socketData, YuppiSocket handledSocket)
        {
            //Create new lobby
            if (socketData.destination == SpecificIdentity.CreateLobby)
            {
                SocketData response = CreateLobby(socketData, handledSocket);

                handledSocket.Send(response.JsonString().ToByteArray(Encoding));
            }
            //Join to there lobby
            else if (socketData.destination == SpecificIdentity.JoinLobby)
            {
                SocketData response = JoinLobby(socketData, handledSocket);

                handledSocket.Send(response.JsonString().ToByteArray(Encoding));
            }
            // send message to all client (with me)
            else if (socketData.destination == SpecificIdentity.WithMe)
            {
                SendDataAllClients(socketData, handledSocket, false);
            }
            // send message to all client (without me)
            else if (socketData.destination == SpecificIdentity.WithoutMe)
            {
                SendDataAllClients(socketData, handledSocket, true);
            }
            //others
            else
                OnRecieveServer?.Invoke(socketData, this);
        }

        private SocketData CreateLobby(SocketData request, YuppiSocket socket)
        {
            SocketData response = new SocketData(SpecificIdentity.Error, request.source, null);

            //data have not be null
            if (request.data is null)
                return response;

            LobbySettings settings = (LobbySettings)request.data;

            //key have not be null
            if (string.IsNullOrEmpty(settings.AuthorizationKey) || string.IsNullOrWhiteSpace(settings.AuthorizationKey))
                return response;

            //capacity have not be less or equal to zero
            if (settings.Capacity <= 0)
                return response;

            //lobby have not be create same key
            if (lobbies.Keys.Contains(settings.AuthorizationKey))
                return response;

            var newLobby = new YuppiLobby(settings);

            //try add new client
            if (!newLobby.Clients.TryAdd(request.source, socket))
                return response;

            socket.AuthorizationKey = settings.AuthorizationKey;

            //try add new lobby
            if (!lobbies.TryAdd(settings.AuthorizationKey, newLobby))
                return response;

            //success - wow
            response.source = SpecificIdentity.Success;
            return response;
        }

        private SocketData JoinLobby(SocketData request, YuppiSocket socket)
        {
            SocketData response = new SocketData(SpecificIdentity.Error, request.source, null);

            //data have not be null
            if (request.data is null)
                return response;

            string authorizationKey = request.data.ToString();

            //lobby can find by key
            if (!lobbies.Keys.Contains(authorizationKey))
                return response;

            var lobby = lobbies[authorizationKey];

            //player have not add to lobby cause lobby full
            if (lobby.Capacity <= lobby.Clients.Count)
                return response;

            //if player add-able
            if (lobby.Clients.TryAdd(request.source, socket))
                return response;

            socket.AuthorizationKey = authorizationKey;

            //success - wow
            response.source = SpecificIdentity.Success;
            return response;
        }

        private void SendDataAllClients(SocketData request, YuppiSocket socket, bool withoutMe)
        {
            foreach (var client in sockets)
            {
                //if withoutme is true and have same id, do not send data
                if (withoutMe && client.Key == socket.Id)
                    continue;

                SocketData response = new SocketData(socket.Id, client.Key, request.data);

                client.Value.Send(response.JsonString().ToByteArray(Encoding));
            }
        }

        //generate new identity
        private uint GetNewIdentity() => ++identity;
    }
}
