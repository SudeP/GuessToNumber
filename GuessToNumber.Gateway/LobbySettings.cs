using System;

namespace GuessToNumber.Gateway
{
    [Serializable]
    public struct LobbySettings
    {
        public string AuthorizationKey;
        public uint Capacity;
    }
}
