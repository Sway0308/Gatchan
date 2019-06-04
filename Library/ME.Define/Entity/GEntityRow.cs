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
        /// <param name="columns"></param>
        public GEntityRow(DataColumnCollection columns) : base()
        {
            foreach (DataColumn col in columns)
                this.Fields.Add(col.ColumnName, col.DefaultValue);
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
        /// 傳回指定鍵值的快取資料。
        /// </summary>
        /// <param name="key">鍵值。</param>
        public object this[string fieldName]
        {
            get
            {
                if (this.HasField(fieldName))
                    return this.GetValue(fieldName);
                throw new GException("No such field exists");
            }
            set
            {
                if (this.HasField(fieldName))
                    this.SetValue(fieldName, value);
                throw new GException("No such field exists");
            }
        }

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

        /// <summary>
        /// 判斷是否有指定欄位。
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        public bool HasField(string fieldName)
        {
            return this.FieldNames.Any(x => x.SameText(fieldName));
        }

        /// <summary>
        /// 取得欄位值後轉型成int
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        public int ValueAsInt(string fieldName)
        {
            if (this.HasField(fieldName))
                return BaseFunc.CInt(this[fieldName]);
            return 0;
        }

        /// <summary>
        /// 取得欄位值後轉型成double
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        public double ValueAsDouble(string fieldName)
        {
            if (this.HasField(fieldName))
                return BaseFunc.CDouble(this[fieldName]);
            return 0;
        }

        /// <summary>
        /// 取得欄位值後轉型成float
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        public float ValueAsFloat(string fieldName)
        {
            if (this.HasField(fieldName))
                return BaseFunc.CFloat(this[fieldName]);
            return 0;
        }

        /// <summary>
        /// 取得欄位值後轉型成decimal
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        public decimal ValueAsDecimal(string fieldName)
        {
            if (this.HasField(fieldName))
                return BaseFunc.CDecimal(this[fieldName]);
            return 0;
        }

        /// <summary>
        /// 取得欄位值後轉型成string
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        public string ValueAsString(string fieldName)
        {
            if (this.HasField(fieldName))
                return BaseFunc.CStr(this[fieldName]);
            return "";
        }

        /// <summary>
        /// 取得欄位值後轉型成bool
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        public bool ValueAsBool(string fieldName)
        {
            if (this.HasField(fieldName))
                return BaseFunc.CBool(this[fieldName]);
            return false;
        }

        /// <summary>
        /// 取得欄位值後轉型成DateTime
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        public DateTime ValueAsDateTime(string fieldName)
        {
            if (this.HasField(fieldName))
                return BaseFunc.CDateTime(this[fieldName]);
            return default(DateTime);
        }

        /// <summary>
        /// 取得欄位值後轉型成Guid
        /// </summary>
        /// <param name="fieldName">欄位名稱</param>
        /// <returns></returns>
        public Guid ValueAsGuid(string fieldName)
        {
            if (this.HasField(fieldName))
                return BaseFunc.CGuid(this[fieldName]);
            return Guid.Empty;
        }
    }
}
