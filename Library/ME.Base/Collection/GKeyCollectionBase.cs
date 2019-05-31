using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ME.Base
{
    /// <summary>
    /// 包含鍵值物件集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GKeyCollectionBase<T> : List<T> where T : GKeyCollectionItem
    {
        /// <summary>
        /// 傳回指定鍵值的快取資料。
        /// </summary>
        /// <param name="key">鍵值。</param>
        public T this[string key]
        {
            get
            {
                var result = this.FirstOrDefault(x => x.Key.SameText(key));
                if (result != null)
                    return result;
                throw new GException("No such key exists");
            }
            set
            {
                var result = this.FirstOrDefault(x => x.Key.SameText(key));
                if (result != null)
                    result = value;
                throw new GException("No such key exists");
            }
        }

        /// <summary>
        /// 新增快取物件
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void AddItem(T value)
        {
            if (!this.Contains(value.Key))
                this.Add(value);
            else
                this[value.Key] = value;
        }

        /// <summary>
        /// 是否包含指定鍵值的資料
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            return this.Any(x => StrFunc.SameText(x.Key, key));
        }
    }
}
