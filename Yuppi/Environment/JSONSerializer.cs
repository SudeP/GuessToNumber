using System.Web.Script.Serialization;

namespace Yuppi.Environment
{
    public class JSONSerializer
    {
        public JSONSerializer(JavaScriptTypeResolver javaScriptTypeResolver = null)
        {
            serializer = new JavaScriptSerializer(javaScriptTypeResolver);
        }
        private readonly JavaScriptSerializer serializer;

        public string Serialize<T>(T t)
        {
            string jsonString = serializer.Serialize(t);

            return jsonString;
        }

        public T Deserialize<T>(string jsonString)
        {
            T t = serializer.Deserialize<T>(jsonString);

            return t;
        }
    }
}
