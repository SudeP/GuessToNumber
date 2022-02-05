using System;
using System.Text;
using System.Web.Script.Serialization;

namespace GuessToNumber.Gateway
{
    public static class YuppiExtensions
    {
        public static JavaScriptSerializer serializer = new JavaScriptSerializer();
        public static int Int<TValue>(this TValue tEnum) where TValue : Enum => (int)(object)tEnum;
        public static string JsonString(this object @object) => serializer.Serialize(@object);
        public static T JsonObject<T>(this string jsonText) => serializer.Deserialize<T>(jsonText);
        public static T JsonConvert<T>(this object @object) => serializer.ConvertToType<T>(@object);
        public static bool JsonObject<T>(this string jsonText, out T @object)
        {
            try
            {
                @object = serializer.Deserialize<T>(jsonText);
                return true;
            }
            catch
            {
                @object = default;
                return false;
            }
        }
        public static string ToString(this byte[] byteArray, Encoding encoding) => encoding.GetString(byteArray, 0, byteArray.Length).Replace("\0", "");
        public static byte[] ToByteArray(this string @string, Encoding encoding) => encoding.GetBytes(@string);
    }
}