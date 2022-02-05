using System.Collections.Concurrent;

namespace GuessToNumber.Gateway
{
    public class YuppiLobby
    {
        public YuppiLobby(LobbySettings lobbySettings)
        {
            AuthorizationKey = lobbySettings.AuthorizationKey;
            Capacity = lobbySettings.Capacity;
            Clients = new ConcurrentDictionary<uint, YuppiSocket>();
        }
        public LobbySettings Settings { get; internal set; }
        public uint Capacity { get; internal set; }
        public string AuthorizationKey { get; internal set; }
        public ConcurrentDictionary<uint, YuppiSocket> Clients { get; internal set; }
    }
}