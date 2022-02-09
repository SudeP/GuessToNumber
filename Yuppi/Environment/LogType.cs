using System;

namespace Yuppi.Environment
{
    [Serializable]
    public enum LogType : byte
    {
        None,
        Error,
        Warning,
        Log,
        Info
    }
}