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

        /// <summary>
        /// 尋找指定定義欄位。
        /// </summary>
        /// <param name="fieldName">[欄位名稱] 或 [資料表.欄位名稱]。</param>
        public GFieldDefine FindField(string fieldName)
        {
            string sTableName;
            string sFieldName;

            if (StrFunc.StrContains(fieldName, "."))
            {
                StrFunc.StrSplitFieldName(fieldName, out sTableName, out sFieldName);
            }
            else
            {
                sTableName = this.ProgID;
                sFieldName = fieldName;
            }

            return FindField(sTableName, sFieldName);
        }

        /// <summary>
        /// 在資料表及延伸資料表尋找指定欄位定義。
        /// </summary>
        /// <param name="tableName">資料表名稱。</param>
        /// <param name="fieldName">欄位名稱。</param>
        public GFieldDefine FindField(string tableName, string fieldName)
        {
            var realTableName = StrFunc.StrIsEmpty(tableName) ? this.ProgID : tableName;
            var tableDefine = this.Tables[realTableName];
            if (BaseFunc.IsNotNull(tableDefine))
                return tableDefine.Fields[fieldName];
            else
                return null;
        }
    }
}
