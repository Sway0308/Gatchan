using ME.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// Entity 資料列 介面
    /// </summary>
    public interface IEntityRow
    {
        /// <summary>
        /// 欄位值集合
        /// </summary>
        GDictionary<object> Fields { get; }
        
        /// <summary>
        /// 欄位名稱集合
        /// </summary>
       IEnumerable<string> FieldNames { get; }

        /// <summary>
        /// 傳回指定欄位名稱的欄位值。
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        object GetValue(string fieldName);

        /// <summary>
        /// 設定欄位值
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <param name="value">欄位值</param>
        void SetValue(string fieldName, object value);

        /// <summary>
        /// 轉換為真正的 Entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T ToRealEntity<T>(T entity) where T : IEntityRow;
    }
}
