using Yuppi.Environment;

namespace Yuppi.Delegates
{
    public delegate void OnLogDelegate(object sender, string message, string stackTrace, LogType type);
}