using ME.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Define
{
    /// <summary>
    /// 基底欄位定義
    /// </summary>
    public class GBaseField : GKeyCollectionItem
    {
        /// <summary>
        /// 欄位名稱
        /// </summary>
        [JsonProperty(Order = -2)]
        public string FieldName { get => this.Key; set => this.Key = value; }
        /// <summary>
        /// 顯示名稱
        /// </summary>
        [JsonProperty(Order = -2)]
        public string DisplayName { get; set; } = string.Empty;
        /// <summary>
        /// 資料型別。
        /// </summary>
        [JsonProperty(Order = -2)]
        public EFieldDbType DbType { get; set; } = EFieldDbType.String;
    }
}
