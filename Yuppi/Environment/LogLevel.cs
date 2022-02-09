namespace Yuppi.Environment
{
    public static class LogLevel
    {
        public static LogType level = LogType.Info;
        public static bool IsEnabled(LogType logType)
        {
            return (byte)level >= (byte)logType;
        }
    }
}