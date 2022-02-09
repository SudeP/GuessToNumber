using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Yuppi.Environment
{
    public static class Extensions
    {
        public static List<T> ToList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }
        /// <summary>
        /// Kullanıldığı yerin Method adını geriye döner
        /// </summary>
        /// <param name="frameIndex">kaç tane geri method gideceğini belirtir.</param>
        /// <returns>Methodun adı</returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string MethodName(int frameIndex = 1)
        {
            var st = new StackTrace();

            var sf = st.GetFrame(frameIndex);
            string methodName = sf.GetMethod().Name;

            return methodName;
        }
        /// <summary>
        /// Yapılan bir işlemi index ile bilgisini geriye döndürür.
        /// </summary>
        /// <param name="frameIndex">hangi işlemin olduğunu belirtecek index</param>
        /// <returns>İşlemlerin listesi</returns>
        public static string StackFrameDetail(int frameIndex = 1)
        {
            var st = new StackTrace(true);

            var sf = st.GetFrame(frameIndex);

            var method = sf.GetMethod();

            string location = $"{method.DeclaringType.FullName}.{method.Name}:({sf.GetFileLineNumber()},{sf.GetFileColumnNumber()})";

            return location;
        }
        /// <summary>
        /// O ana kadarki tüm geçilmiş adımların listesini verir.
        /// </summary>
        /// <param name="removeRange">kaç tane geri method gideceğini belirtir.</param>
        /// <returns>İşlemlerin listesi</returns>
        public static string StackFrames(int removeRange = 1)
        {
            string locations = string.Empty;

            StackTrace st = new StackTrace(true);

            List<StackFrame> frames = st.GetFrames().ToList().Skip(removeRange).ToList();

            foreach (StackFrame sf in frames)
            {
                var method = sf.GetMethod();

                locations += System.Environment.NewLine;

                if (method.DeclaringType != null)
                {
                    locations += method.DeclaringType.FullName;
                }

                locations += "." + $@".{method.Name}:({sf.GetFileLineNumber()},{sf.GetFileColumnNumber()})";
            }

            return locations;
        }
        /// <su
    }
}
