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
    public class GKeyCollectionBase<T> : GCollectionBase<T>, IKeyCollectionBase where T : GKeyCollectionItem
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
        /// 傳回指定鍵值的快取資料。
        /// </summary>
        /// <param name="key">鍵值。</param>
        public virtual T this[string key]
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
        /// <param name="key">鍵值</param>
        /// <param name="item">項目</param>
        public new virtual void Add(T item)
        {
            if (item.Collection == this)
                return;
            if (item.Collection != null)
                throw new GException("This item is already setted for another collection");

            if (!this.Contains(item.Key))
            {
                base.Add(item);
                item.SetCollection(this);
            }
            else
                this[item.Key] = item;
        }

        /// <summary>
        /// 是否包含指定鍵值的資料
        /// </summary>
        /// <param name="key">鍵值</param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            return this.Any(x => StrFunc.SameText(x.Key, key));
        }
    }
}
