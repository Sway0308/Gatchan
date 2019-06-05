using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace ME.Base
{
    /// <summary>
    /// 序列化函式庫。
    /// </summary>
    public class SerializeFunc
    {
        /// <summary>
        /// 取得 JSON 序列化設定。
        /// </summary>
        /// <param name="ignoreDefaultValue">是否忽略預設值。</param>
        /// <param name="ignoreNullValue">是否忽略 Null 值。</param>
        /// <param name="includeTypeName">是否包含型別名稱。</param>
        private static JsonSerializerSettings GetJsonSerializerSettings(bool ignoreDefaultValue, bool ignoreNullValue, bool includeTypeName)
        {
            JsonSerializerSettings oSettings;

            oSettings = new JsonSerializerSettings();
            oSettings.Formatting = Formatting.Indented;
            // 忽略預設值
            if (ignoreDefaultValue)
                oSettings.DefaultValueHandling = DefaultValueHandling.Ignore;
            // 忽略 Null 值
            if (ignoreNullValue)
                oSettings.NullValueHandling = NullValueHandling.Ignore;
            // 加入型別名稱
            if (includeTypeName)
                oSettings.TypeNameHandling = TypeNameHandling.Auto;
            // 列舉型別使用字串
            oSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            return oSettings;
        }

        /// <summary>
        /// 將物件序列化為 JSON 字串。
        /// </summary>
        /// <param name="value">物件。</param>
        /// <param name="ignoreDefaultValue">是否忽略預設值。</param>
        /// <param name="ignoreNullValue">是否忽略 Null 值。</param>
        /// <param name="includeTypeName">是否包含型別名稱。</param>
        public static string ObjectToJson(object value, bool ignoreDefaultValue = false, bool ignoreNullValue = false, bool includeTypeName = false)
        {
            JsonSerializerSettings oSettings;
            string sJson;

            // 序列化為 JSON 字串
            oSettings = GetJsonSerializerSettings(ignoreDefaultValue, ignoreNullValue, includeTypeName);
            sJson = JsonConvert.SerializeObject(value, oSettings);

            return sJson;
        }

        /// <summary>
        /// 將 JOSN 字串反序列化為物件。
        /// </summary>
        /// <param name="json">JSON 字串。</param>
        /// <param name="type">型別。</param>
        /// <param name="includeTypeName">是否包含型別名稱。</param>
        public static object JsonToObject(string json, Type type, bool includeTypeName = false)
        {
            JsonSerializerSettings oSettings;
            object oValue;

            // 反序列化 JSON 字串
            oSettings = GetJsonSerializerSettings(true, false, includeTypeName);
            oValue = JsonConvert.DeserializeObject(json, type, oSettings);
            return oValue;
        }

        /// <summary>
        /// 將 JOSN 字串反序列化為物件。
        /// </summary>
        /// <typeparam name="T">泛型型別。</typeparam>
        /// <param name="json">JSON 字串。</param>
        /// <param name="includeTypeName">是否包含型別名稱。</param>
        public static T JsonToObject<T>(string json, bool includeTypeName = false)
        {
            return (T)JsonToObject(json, typeof(T), includeTypeName);
        }

        /// <summary>
        /// 將物件序列化為二進位資料。
        /// </summary>
        /// <param name="value">物件。</param>
        public static byte[] ObjectToBinary(object value)
        {
            BinaryFormatter oFormatter;
            byte[] oBuffer;

            using (MemoryStream stream = new MemoryStream())
            {
                oFormatter = new BinaryFormatter();
                oFormatter.Serialize(stream, value);
                oBuffer = stream.ToArray();
            }

            return oBuffer;
        }

        /// <summary>
        /// 將二進位資料反序列化為物件。
        /// </summary>
        /// <typeparam name="T">泛型型別。</typeparam>
        /// <param name="bytes">二進位資料。</param>
        public static T BinaryToObject<T>(byte[] bytes)
        {
            BinaryFormatter oFormatter;
            object oValue;

            using (MemoryStream stream = new MemoryStream(bytes))
            {
                oFormatter = new BinaryFormatter();
                oValue = oFormatter.Deserialize(stream);
            }

            return (T)oValue;
        }
    }
}
