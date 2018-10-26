using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementary
{
    public class JsonFunc
    {
        /// <summary>
        /// 將物件序列化為 JSON 字串。
        /// </summary>
        /// <param name="value">物件。</param>
        /// <param name="ignoreDefaultValue">是否忽略預設值。</param>
        /// <param name="ignoreNullValue">是否忽略 Null 值。</param>
        /// <param name="includeTypeName">是否包含型別名稱。</param>
        public static string ObjectToJson(object value, bool ignoreDefaultValue = false, bool ignoreNullValue = false, bool includeTypeName = false)
        {
            // 序列化為 JSON 字串
            var oSettings = GetJsonSerializerSettings(ignoreDefaultValue, ignoreNullValue, includeTypeName);
            return JsonConvert.SerializeObject(value, oSettings);
        }

        /// <summary>
        /// 將 JOSN 字串反序列化為物件。
        /// </summary>
        /// <param name="json">JSON 字串。</param>
        /// <param name="type">型別。</param>
        /// <param name="includeTypeName">是否包含型別名稱。</param>
        public static T JsonToObject<T>(string json, bool includeTypeName = false)
        {
            // 反序列化 JSON 字串
            var oSettings = GetJsonSerializerSettings(true, false, includeTypeName);
            return (T)JsonConvert.DeserializeObject(json, typeof(T), oSettings);
        }

        /// <summary>
        /// 取得 JSON 序列化設定。
        /// </summary>
        /// <param name="ignoreDefaultValue">是否忽略預設值。</param>
        /// <param name="ignoreNullValue">是否忽略 Null 值。</param>
        /// <param name="includeTypeName">是否包含型別名稱。</param>
        private static JsonSerializerSettings GetJsonSerializerSettings(bool ignoreDefaultValue, bool ignoreNullValue, bool includeTypeName)
        {
            var oSettings = new JsonSerializerSettings();
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
    }
}
