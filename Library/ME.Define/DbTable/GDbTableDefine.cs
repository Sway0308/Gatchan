using ME.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Define
{
    /// <summary>
    /// 實體資料表定義。
    /// </summary>
    public class GDbTableDefine : GKeyCollectionItem
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TableName { get => base.Key; set => base.Key = value; }
        /// <summary>
        /// 顯示名稱
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;
        /// <summary>
        /// 欄位定義集合
        /// </summary>
        public GDbFieldDefineCollection Fields { get; } = new GDbFieldDefineCollection();
    }
}
