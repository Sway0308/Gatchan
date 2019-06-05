using ME.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ME.Define
{
    /// <summary>
    /// 資料表定義
    /// </summary>
    public class GTableDefine : GKeyCollectionItem
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public GTableDefine()
        { 
            this.Fields = new GFieldDefineCollection(this);
        }

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
        /// Detail資料表對應Master資料表的主鍵欄位名稱，以逗點分隔多個欄位
        /// </summary>
        public string MasterKey { get; set; } = string.Empty;
        /// <summary>
        /// 主索引鍵，以逗點分隔多個欄位名稱
        /// </summary>
        public string PrimaryKey { get; set; } = string.Empty;
        /// <summary>
        /// 欄位集合
        /// </summary>
        public GFieldDefineCollection Fields { get; }
        /// <summary>
        /// 商業邏輯載入物件型別
        /// </summary>
        public GInstanceType EntityInstanceType { get; set; } = new GInstanceType();

        /// <summary>
        /// 預設排序欄位集合。
        /// </summary>
        public GSortFieldCollection SortFields { get; set; } = new GSortFieldCollection();

        /// <summary>
        /// 資料過濾條件項目集合
        /// </summary>
        public GFilterItemCollection FilterItems { get; set; } = new GFilterItemCollection();

        /// <summary>
        /// Table主索引鍵，以逗點分隔多個欄位名稱。
        /// </summary>
        public string TablePrimaryKey { get; set; }

        /// <summary>
        /// 是否建立實體資料表。
        /// </summary>
        public bool IsCreateDbTable { get; set; } = true;

        /// <summary>
        /// 取得設定關連取回的編號欄位。
        /// </summary>
        /// <param name="fieldDefine">欄位定義</param>
        public GFieldDefine GetLinkReturnActiveField(GFieldDefine fieldDefine)
        {
            if (StrFunc.StrIsNotEmpty(fieldDefine.LinkFieldName))
                // 傳回關連來源欄位
                return this.Fields[fieldDefine.LinkFieldName];
            else if (StrFunc.StrIsNotEmpty(fieldDefine.LinkProgID))
                // 內碼欄位
                return fieldDefine;
            else
                return null;
        }

        /// <summary>
        /// 程式定義。
        /// </summary>
        [JsonIgnore]
        public GProgramDefine ProgramDefine => ((GTableDefineCollection)this.Collection).Owner as GProgramDefine;

        /// <summary>
        /// 是否為主資料表
        /// </summary>
        [JsonIgnore]
        public bool IsMaster => this.ProgramDefine.ProgID.SameText(this.TableName);

        /// <summary>
        /// 物件描述。
        /// </summary>
        public override string ToString()
        {
            return StrFunc.StrFormat("{0} - {1}, {2}", this.TableName, this.DisplayName, this.DbTableName);
        }
    }
}
