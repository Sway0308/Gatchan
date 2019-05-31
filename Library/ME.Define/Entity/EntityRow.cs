using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ME.Base;

namespace ME.Define
{
    /// <summary>
    /// Entity 資料列
    /// </summary>
    public class EntityRow : IEntityRow
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public EntityRow()
        {
            var props = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.SetProperty);
            foreach (var prop in props.Where(x => x.CanWrite))
            {
                this.PropNames.Add(prop);
            }
        }

        /// <summary>
        /// 屬性名稱集合
        /// </summary>
        private List<PropertyInfo> PropNames { get; } = new List<PropertyInfo>();

        /// <summary>
        /// 欄位值集合
        /// </summary>
        public ADictionary<object> Fields { get; } = new ADictionary<object>();

        /// <summary>
        /// 傳回指定鍵值的欄位值。
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object this[string key]
        {
            get
            {
                var propInfo = this.PropNames.FirstOrDefault(x => x.Name.SameText(key));
                if (propInfo != null)
                    return propInfo.GetValue(this);
                else if (this.Fields.ContainsKey(key))
                    return this.Fields[key];
                else
                    throw new Exception("No such column exist");
            }
        }

        /// <summary>
        /// 設定欄位值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SetValue(string key, object value)
        {
            var propInfo = this.PropNames.FirstOrDefault(x => x.Name.SameText(key));
            if (propInfo != null)
                propInfo.SetValue(this, value);
            else if (this.Fields.ContainsKey(key))
                this.Fields[key] = value;
            else
                throw new Exception("No such column exist");
        }
    }
}
