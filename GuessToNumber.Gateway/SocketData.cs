using System;

namespace GuessToNumber.Gateway
{
    [Serializable]
    public struct SocketData
    {
        internal SocketData(uint __source, uint __destination, object __data)
        {
            source = __source;
            destination = __destination;
            data = __data;
        }

        public uint source;

        public uint destination;

        public object data;
    }
}