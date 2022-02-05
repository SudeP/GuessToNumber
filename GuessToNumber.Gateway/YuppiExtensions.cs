using Newtonsoft.Json;
using System;
using System.Text;

namespace GuessToNumber.Gateway
{
    public static class YuppiExtensions
    {
        public static int Int<TValue>(this TValue tEnum) where TValue : Enum => (int)(object)tEnum;
        public static string JsonString(this object @object) => JsonConvert.SerializeObject(@object);
        public static T JsonObject<T>(this string jsonText) => JsonConvert.DeserializeObject<T>(jsonText);
        public static bool JsonObject<T>(this string jsonText, out T @object)
        {
            bool success = true;

            var settings = new JsonSerializerSettings
            {
                Error = (sender, args) => { success = false; args.ErrorContext.Handled = true; },
                MissingMemberHandling = MissingMemberHandling.Error
            };

            @object = JsonConvert.DeserializeObject<T>(jsonText, settings);

            return success;
        }
        public static string ToString(this byte[] byteArray, Encoding encoding) => encoding.GetString(byteArray, 0, byteArray.Length).Replace("\0", "");
        public static byte[] ToByteArray(this string @string, Encoding encoding) => encoding.GetBytes(@string);
    }
}