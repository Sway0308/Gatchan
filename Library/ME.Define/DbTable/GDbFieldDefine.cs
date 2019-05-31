using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Define
{
    /// <summary>
    /// 實體欄位定義
    /// </summary>
    public class GDbFieldDefine : GBaseField
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public GDbFieldDefine()
        { }

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="fieldDefine">欄位定義</param>
        public GDbFieldDefine(GFieldDefine fieldDefine)
        {
            this.FieldName = fieldDefine.FieldName;
            this.DisplayName = fieldDefine.DisplayName;
            this.AllowNull = fieldDefine.AllowNull;
            this.DbType = fieldDefine.DbType;
            this.MaxLength = fieldDefine.MaxLength;
        }

        /// <summary>
        /// 最大長度
        /// </summary>
        public int MaxLength { get; set; }
        /// <summary>
        /// 是否允許 Null 值
        /// </summary>
        public bool AllowNull { get; set; }
    }
}
