namespace GuessToNumber.Gateway
{
    public delegate void RecieveListenHandler(SocketData socketData, YuppiSocket handledSocket);
    public delegate void RecieveServerHandler(SocketData socketData, ISocket handledSocket);
    public delegate void RecieveClientHandler(SocketData socketData);
    public delegate void YuppiLogHandler(string message, string stackTrace, bool isError);
}