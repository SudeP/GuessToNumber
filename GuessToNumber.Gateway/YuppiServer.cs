using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessToNumber.Gateway
{
    public class YuppiServer : Yuppi
    {
        public YuppiServer(IPEndPoint iPEndPoint, Encoding encoding) : base(iPEndPoint, encoding)
        {
        }

        public override event YuppiLogHandler OnLog;
        public event RecieveServerHandler OnRecieveServer;
        private uint identity;
        private Task acceptHandleTask;
        private CancellationTokenSource acceptHandleTaskCancellationTokenSource;
        public ConcurrentDictionary<string, YuppiLobby> lobbies;
        public ConcurrentDictionary<uint, YuppiSocket> sockets;

        public new void Stop()
        {
            OnLog?.Invoke("Stopped server", "Stop", false);

            base.Stop();

            if (acceptHandleTaskCancellationTokenSource != null && !acceptHandleTaskCancellationTokenSource.IsCancellationRequested)
            {
                acceptHandleTaskCancellationTokenSource.Cancel(false);
                acceptHandleTaskCancellationTokenSource.Dispose();
            }

            if (sockets != null)
                foreach (var socket in sockets)
                    if (socket.Value != null && socket.Value.Socket != null)
                        DestorySocket(socket.Value);


            OnRecieveListen -= YuppiServer_OnHandleRecieve;
        }

        public override void Start()
        {
            OnRecieveListen += YuppiServer_OnHandleRecieve;

            base.Start();

            lobbies = new ConcurrentDictionary<string, YuppiLobby>();
            sockets = new ConcurrentDictionary<uint, YuppiSocket>();

            OnLog?.Invoke("Started server", "Start", false);

            identity = SpecificIdentity.IdentitySeed;

            Id = GetNewIdentity();
            Pipline.Id = Id;

            acceptHandleTaskCancellationTokenSource = new CancellationTokenSource();

            acceptHandleTask = new Task(AcceptHandle, acceptHandleTaskCancellationTokenSource.Token);

            acceptHandleTask.Start();
        }

        private void AcceptHandle()
        {
            while (true)
            {
                try
                {
                    Socket newClientSocket = Pipline.Socket.Accept();

                    YuppiSocket newPipline = new YuppiSocket(newClientSocket);

                    OnLog?.Invoke("Accept new client", "AcceptHandle", false);

                    var newIdentity = GetNewIdentity();
                    newPipline.Id = newIdentity;

                    newPipline.Socket.Send(newIdentity.ToString().ToByteArray(Encoding));

                    byte[] buffer = new byte[uint.MaxValue.ToString().ToByteArray(Encoding).Length];

                    newPipline.Socket.Receive(buffer);

                    if (byte.TryParse(buffer.ToString(Encoding), out byte clientId))
                        if (newIdentity == clientId)
                            if (sockets.TryAdd(clientId, newPipline))
                            {
                                OnLog?.Invoke("New client authorize. Id = " + clientId, null, false);
                                StartListen(clientId, newPipline);

                                continue;
                            }

                    OnLog?.Invoke($@"Unsuccess process. Destory Socket. Client Id = {newIdentity}", "AcceptHandle", true);
                    DestorySocket(newPipline);
                }
                catch (Exception ex)
                {
                    OnLog?.Invoke(ex.Message, "AcceptHandle", true);
                }
            }
        }

        private void YuppiServer_OnHandleRecieve(SocketData socketData, YuppiSocket handledSocket)
        {
            OnLog?.Invoke($@"Handle new Recieve. Destination Uint = {socketData.destination}. Sender id = " + handledSocket.Id, "YuppiServer_OnHandleRecieve", false);
            //Create new lobby
            if (socketData.destination == SpecificIdentity.CreateLobby)
            {
                SocketData response = CreateLobby(socketData, handledSocket);

                handledSocket.Socket.Send(response.JsonString().ToByteArray(Encoding));

                return;
            }
            //Join to there lobby
            else if (socketData.destination == SpecificIdentity.JoinLobby)
            {
                SocketData response = JoinLobby(socketData, handledSocket);

                handledSocket.Socket.Send(response.JsonString().ToByteArray(Encoding));

                return;
            }
            // send message to all client (with me)
            else if (socketData.destination == SpecificIdentity.WithMe)
            {
                SendDataAllClients(socketData, handledSocket, false);

                return;
            }
            // send message to all client (without me)
            else if (socketData.destination == SpecificIdentity.WithoutMe)
            {
                SendDataAllClients(socketData, handledSocket, true);

                return;
            }
            //send message to Server
            else if (socketData.destination == SpecificIdentity.ServerId)
            {
                OnRecieveServer?.Invoke(socketData, this);

                return;
            }
            //send (client/server) to client
            else if (socketData.destination > SpecificIdentity.ServerId)
            {
                if (lobbies.TryGetValue(handledSocket.AuthorizationKey, out YuppiLobby targetLobby))
                {
                    if (targetLobby.Clients.TryGetValue(socketData.destination, out YuppiSocket target))
                    {
                        target.Socket.Send(socketData.JsonString().ToByteArray(Encoding));

                        return;
                    }
                }
            }

            OnLog?.Invoke($@"Unhandled identity. İdentity = " + socketData.destination, "YuppiServer_OnHandleRecieve", true);
        }

        private SocketData CreateLobby(SocketData request, YuppiSocket socket)
        {
            SocketData response = new SocketData(SpecificIdentity.Error, request.source, null);

            //data have not be null
            if (request.data is null)
            {
                OnLog?.Invoke($@"data have not be null", "CreateLobby", true);
                return response;
            }

            LobbySettings settings = request.data.JsonConvert<LobbySettings>();

            //key have not be null
            if (string.IsNullOrEmpty(settings.AuthorizationKey) || string.IsNullOrWhiteSpace(settings.AuthorizationKey))
            {
                OnLog?.Invoke($@"key have not be null", "CreateLobby", true);
                return response;
            }

            //capacity have not be less or equal to zero
            if (settings.Capacity <= 0)
            {
                OnLog?.Invoke($@"capacity have not be less or equal to zero. Capacity = {settings.Capacity}", "CreateLobby", true);
                return response;
            }

            //lobby have not be create same key
            if (lobbies.Keys.Contains(settings.AuthorizationKey))
            {
                OnLog?.Invoke($@"lobby have not be create same key. Key = {settings.AuthorizationKey}", "CreateLobby", true);
                return response;
            }

            var newLobby = new YuppiLobby(settings);

            //try add new client
            if (!newLobby.Clients.TryAdd(request.source, socket))
            {
                OnLog?.Invoke($@"didn't add new client. Client Id = {socket.Id}", "CreateLobby", true);
                return response;
            }

            socket.AuthorizationKey = settings.AuthorizationKey;

            //try add new lobby
            if (!lobbies.TryAdd(settings.AuthorizationKey, newLobby))
            {
                OnLog?.Invoke($@"didn't add new lobby. Lobby Key = {settings.AuthorizationKey}", "CreateLobby", true);
                return response;
            }

            OnLog?.Invoke($@"New lobby created. Auth Key = {settings.AuthorizationKey}", "JoinLobby", false);
            //success - wow
            response.source = SpecificIdentity.Success;
            return response;
        }

        private SocketData JoinLobby(SocketData request, YuppiSocket socket)
        {
            SocketData response = new SocketData(SpecificIdentity.Error, request.source, null);

            //data have not be null
            if (request.data is null)
            {
                OnLog?.Invoke($@"data have not be null", "JoinLobby", true);
                return response;
            }

            string authorizationKey = request.data.ToString();

            //lobby can find by key
            if (!lobbies.Keys.Contains(authorizationKey))
            {
                OnLog?.Invoke($@"lobby can not find by key. Key = {authorizationKey}", "JoinLobby", true);
                return response;
            }

            var lobby = lobbies[authorizationKey];

            //player have not add to lobby cause lobby full
            if (lobby.Capacity <= lobby.Clients.Count)
            {
                OnLog?.Invoke($@"player have not add to lobby cause lobby full. Capacity = {lobby.Capacity}", "JoinLobby", true);
                return response;
            }

            //if player add-able
            if (!lobby.Clients.TryAdd(request.source, socket))
            {
                OnLog?.Invoke($@"didn't joined client. Client Id = {socket.Id}", "JoinLobby", true);
                return response;
            }

            socket.AuthorizationKey = authorizationKey;

            OnLog?.Invoke($@"Client joined to lobby. Client Id = {socket.Id}. Auth Key = {authorizationKey}", "JoinLobby", false);
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

                client.Value.Socket.Send(response.JsonString().ToByteArray(Encoding));
            }
        }

        //generate new identity
        private uint GetNewIdentity() => ++identity;
    }
}
