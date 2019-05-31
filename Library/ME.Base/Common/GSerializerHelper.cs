using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Serialization;

namespace ME.Base
{
    /// <summary>
    /// 物件序列化與反序化輔助類別。
    /// </summary>
    public class GSerializerHelper
    {
        /// <summary>
        /// 將物件序列化為 XML 字串。
        /// </summary>
        /// <param name="value">物件。</param>
        public static string ObjectToXml(object value)
        {
            string sXml;
            XmlSerializer oSerializer = new XmlSerializer(value.GetType());
            using (StringWriter oStringWriter = new StringWriter())
            {
                oSerializer.Serialize((TextWriter)oStringWriter, value);
                sXml = oStringWriter.ToString();
            }

            return sXml;
        }

        /// <summary>
        /// 將 XML 字串反序列化為物件。
        /// </summary>
        /// <param name="xml">XML 字串。</param>
        /// <param name="type">型別。</param>
        public static object XmlToObject(string xml, Type type)
        {
            object oValue;
            XmlSerializer oSerializer = new XmlSerializer(type);
            using (StringReader oStringReader = new StringReader(xml))
            {
                oValue = oSerializer.Deserialize(oStringReader);
            }
            return oValue;
        }
        
        /// <summary>
        /// 將物件序列化為 JSON 字串。
        /// </summary>
        /// <param name="value">物件。</param>
        public static string ObjectToJson(object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }

        /// <summary>
        /// 將 JOSN 字串反序列化為物件。
        /// </summary>
        /// <param name="json">JSON 字串。</param>
        /// <param name="type">型別。</param>
        public static object JsonToObject(string json, Type type)
        {
            return JsonConvert.DeserializeObject(json, type);
        }

        /// <summary>
        /// 將 JOSN 字串反序列化為物件。
        /// </summary>
        /// <param name="json">JSON 字串。</param>
        public static T JsonToObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
