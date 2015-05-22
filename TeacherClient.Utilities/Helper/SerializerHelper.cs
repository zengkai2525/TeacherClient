using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TeacherClient.Utilities.Helper
{
    public class SerializerHelper
    {
        private static SerializerHelper _instance;
        /// <summary>
        /// 单例
        /// </summary>
        public static SerializerHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SerializerHelper();
                }
                return _instance;
            }
        }

        /// <summary>
        /// xml序列化到字符串
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        public string XmlSerialize<T>(T obj)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(obj.GetType());
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);
                ser.Serialize(sw, obj);

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("序列化失败,原因:" + ex.Message);
            }
        }

        /// <summary>
        /// xml反序列化到对象
        /// </summary>
        /// <typeparam name="T">反序列化对象</typeparam>
        /// <param name="obj"></param>
        /// <param name="xml"></param>
        /// <returns></returns>
        public T XmlDeserialize<T>(T obj, string xml)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(obj.GetType());
                StringReader sr = new StringReader(xml);
                return (T)xs.Deserialize(sr);
            }
            catch (Exception ex)
            {
                throw new Exception("反序列化失败,原因:" + ex.Message);
            }
        }
    }
}
