using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ME.Base;
using ME.Define;
using Newtonsoft.Json;

namespace ME.Define
{
    /// <summary>
    /// Entity 資料列
    /// </summary>
    public class GEntityRow : IEntityRow
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public GEntityRow()
        {
            var props = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var prop in props.Where(x => x.CanWrite))
                this.PropNames.Add(prop);
        }

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="originalRow">欄位定義</param>
        public GEntityRow(IEntityRow originalRow) : base()
        {
            ImportFieldNames(originalRow);
            ImportFieldValues(originalRow);
        }

        /// <summary>
        /// 屬性名稱集合
        /// </summary>
        [JsonIgnore]
        private List<PropertyInfo> PropNames { get; } = new List<PropertyInfo>();

        /// <summary>
        /// 欄位值集合
        /// </summary>
        public GDictionary<object> Fields { get; } = new GDictionary<object>();

        /// <summary>
        /// 欄位名稱集合
        /// </summary>
        [JsonIgnore]
        public IEnumerable<string> FieldNames => this.Fields.Keys.ToList();

        /// <summary>
        /// 傳回指定欄位名稱的欄位值。
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        public object GetValue(string fieldName)
        {            
            var propInfo = this.PropNames.FirstOrDefault(x => x.Name.SameText(fieldName));
            if (propInfo != null)
                return propInfo.GetValue(this);
            else if (this.Fields.ContainsKey(fieldName))
                return this.Fields[fieldName];
            else
                throw new Exception("No such column exist");
        }

        /// <summary>
        /// 設定欄位值
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <param name="value">欄位值</param>
        public void SetValue(string fieldName, object value)
        {
            var propInfo = this.PropNames.FirstOrDefault(x => x.Name.SameText(fieldName));
            if (propInfo != null)
                propInfo.SetValue(this, value);

            if (this.Fields.ContainsKey(fieldName))
                this.Fields[fieldName] = value;
            else
                throw new Exception("No such column exist");
        }

        /// <summary>
        /// 匯入欄位
        /// </summary>
        /// <param name="originalRow">來源資料列</param>
        private void ImportFieldNames(IEntityRow originalRow)
        {
            foreach (var field in originalRow.Fields)
                this.Fields.Add(field.Key, DataFunc.GetDefaultValue(field.Value.GetType()));
        }

        /// <summary>
        /// 匯入欄位值集合到來源資料列
        /// </summary>
        /// <param name="originalRow">來源資料列</param>
        public void ImportFieldValues(IEntityRow originalRow)
        {
            foreach (var f in this.FieldNames.Where(x => x.SameTextOr(originalRow.FieldNames)))
                this.SetValue(f, originalRow.GetValue(f));
        }

        /// <summary>
        /// 轉換為真正的 Entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T ToRealEntity<T>(T realEntity) where T : IEntityRow
        {
            this.ImportFieldValues(realEntity);
            var props = from p in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public)
                        where p.Name.SameTextOr(this.FieldNames)
                            && p.CanWrite
                        select p;
            foreach (var p in props)
                p.SetValue(realEntity, this.GetValue(p.Name));
            return realEntity;
        }
    }
}
