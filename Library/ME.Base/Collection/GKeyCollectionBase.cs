using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ME.Base
{
    /// <summary>
    /// 包含鍵值物件集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GKeyCollectionBase<T> : List<T>, IKeyCollectionBase where T : GKeyCollectionItem
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public GKeyCollectionBase()
        {
            
        }

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="owner">擁有者</param>
        public GKeyCollectionBase(object owner)
        {
            this.Owner = owner;
        }

        /// <summary>
        /// 擁有者
        /// </summary>
        public object Owner { get; }

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
                return default(T);
            }
            set
            {
                var result = this.FirstOrDefault(x => x.Key.SameText(key));
                if (result != null)
                    result = value;
            }
        }

        /// <summary>
        /// 新增快取物件
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public new virtual void Add(T value)
        {
            if (!this.Contains(value.Key))
            {
                base.Add(value);
                value.SetCollection(this);
            }
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
