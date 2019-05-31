using ME.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ME.Define
{
    /// <summary>
    /// 程式定義
    /// </summary>
    [Serializable]
    public class GProgramDefine : GKeyCollectionItem
    {
        /// <summary>
        /// 程式代碼
        /// </summary>
        public string ProgID { get => this.Key; set => this.Key = value; }
        /// <summary>
        /// 顯示名稱
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;
        /// <summary>
        /// 資料表定義集合
        /// </summary>
        public GTableDefineCollection Tables { get; } = new GTableDefineCollection();
        /// <summary>
        /// 主資料表定義
        /// </summary>
        [JsonIgnore]
        public GTableDefine MasterTable => this.Tables[this.ProgID];
        /// <summary>
        /// 主資料表欄位定義
        /// </summary>
        [JsonIgnore]
        public GFieldDefineCollection MasterFields => this.MasterTable.Fields;
    }
}
