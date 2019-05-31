using ME.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ME.Define
{
    /// <summary>
    /// 資料表定義
    /// </summary>
    [Serializable]
    public class GTableDefine : GKeyCollectionItem
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TableName { get => this.Key; set => this.Key = value; }
        /// <summary>
        /// 實體資料表名稱
        /// </summary>
        public string DbTableName { get; set; } = string.Empty;
        /// <summary>
        /// 顯示名稱
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;
        /// <summary>
        /// 主索引鍵，以逗點分隔多個欄位名稱
        /// </summary>
        public string PrimaryKey { get; set; } = string.Empty;
        /// <summary>
        /// 欄位集合
        /// </summary>
        public GFieldDefineCollection Fields { get; } = new GFieldDefineCollection();
        /// <summary>
        /// 商業邏輯載入物件型別
        /// </summary>
        public GInstanceType EntityInstanceType { get; set; } = new GInstanceType();
    }
}
