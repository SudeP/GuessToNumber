using System;

namespace GuessToNumber.Gateway
{
    public class YuppiPipeLine
    {
        internal YuppiPipeLine(Yuppi _yuppi)
        {
            yuppi = _yuppi;
        }
        private readonly Yuppi yuppi;
        /// <summary>
        /// Client to Server
        /// </summary>
        /// <param name="socketData"></param>
        public void ToServer(object data)
        {
            if (yuppi.IsClient)
                yuppi.Pipline.Socket.Send(new SocketData(yuppi.Id, SpecificIdentity.ServerId, data).JsonString().ToByteArray(yuppi.Encoding));
            else
                throw new Exception("Bro, w r u doing ? Server to Server send data ??? hahahaha");
        }
        /// <summary>
        /// (Client/Server) to Client[ById]
        /// </summary>
        /// <param name="socketData"></param>
        /// <param name="clientId"></param>
        public void ToClient(object data, uint clientId)
        {
            yuppi.Pipline.Socket.Send(new SocketData(yuppi.Id, clientId, data).JsonString().ToByteArray(yuppi.Encoding));
        }
        /// <summary>
        /// (Client/Server) to all clients
        /// </summary>
        /// <param name="socketData"></param>
        /// <param name="withoutMe"></param>
        public void ToClients(object data, bool withoutMe = true)
        {
            yuppi.Pipline.Socket.Send(new SocketData(yuppi.Id, withoutMe ? SpecificIdentity.WithoutMe : SpecificIdentity.WithMe, data).JsonString().ToByteArray(yuppi.Encoding));
        }
    }
}