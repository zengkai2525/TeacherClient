using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeacherClient.Bussiness
{
    /// <summary>
    /// 实例池
    /// </summary>
    public class InstancePool
    {
        /// <summary>
        /// 实例字典
        /// </summary>
        private static Dictionary<string,object> dicInstanceT = new Dictionary<string, object>();

        public static T GetInstanceT<T>()
        {
            T result;
            string typeFullName = typeof (T).FullName;
            if (dicInstanceT.ContainsKey(typeFullName))
            {
                result = (T) dicInstanceT[typeFullName];
            }
            else
            {
                lock (dicInstanceT)
                {
                    result =(T)Activator.CreateInstance(typeof (T));
                }
            }
            return result;
        }

        public static void AddOrUpdateToPool<T>(T t)
        {
            string typeFullName = typeof (T).FullName;
            if (dicInstanceT.ContainsKey(typeFullName))
            {
                dicInstanceT[typeFullName] = t;
            }
            else
            {
                lock (dicInstanceT)
                {
                    dicInstanceT.Add(typeFullName,t);
                }
            }
        }
    }
}
