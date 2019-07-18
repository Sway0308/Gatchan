using System;
using System.Collections;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace ME.Base
{
    /// <summary>
    /// 強型別集合基底類別
    /// </summary>
    /// <typeparam name="T">成員類別。</typeparam>
    public abstract class GCollectionBase<T> : IEnumerable<T>, ICollectionBase where T : ICollectionItem
    {
        /// <summary>
        /// 儲存物件
        /// </summary>
        public List<T> StorageList { get; }= new List<T>();

        /// <summary>
        /// 建構函式。
        /// </summary>
        public GCollectionBase()
        {}

        /// <summary>
        ///  擁有者。
        /// </summary>
        public virtual object Owner { get; protected set; }

        /// <summary>
        /// 總數
        /// </summary>
        public int Count => this.StorageList.Count;

        /// <summary>
        /// 傳回指定鍵值的快取資料。
        /// </summary>
        /// <param name="key">鍵值。</param>
        public virtual T this[int index]
        {
            get
            {
                return this.StorageList[index];
            }
            set
            {
                this.StorageList[index] = value;
            }
        }

        /// <summary>
        /// 依索引取得成員。
        /// </summary>
        /// <param name="index">索引。</param>
        public object GetItem(int index)
        {
            return this.StorageList[index];
        }

        /// <summary>
        /// 移除成員
        /// </summary>
        /// <param name="item">成員。</param>
        public void Remove(ICollectionItem item)
        {
            this.Remove((T)item);
        }

        /// <summary>
        /// 移除成員。
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            OnRemove(item);
            this.StorageList.Remove(item);
        }

        /// <summary>
        /// 新增成員
        /// </summary>
        /// <param name="item"></param>
        public virtual void Add(T item)
        {
            OnAdd(item);
            item.SetCollection(this);
            this.StorageList.Add(item);
        }

        /// <summary>
        /// 清除清單資料
        /// </summary>
        public void Clear()
        {
            this.StorageList.Clear();
        }

        /// <summary>
        /// Add 事件
        /// </summary>
        /// <param name="value"></param>
        protected virtual void OnAdd(T value)
        {

        }

        /// <summary>
        /// Remove 事件
        /// </summary>
        /// <param name="value"></param>
        protected virtual void OnRemove(T value)
        {

        }

        #region 實作IEnumerable

        /// <summary>
        /// 取得列舉物件
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return this.StorageList.GetEnumerator();
        }

        /// <summary>
        /// 取得列舉泛型物件
        /// </summary>
        /// <returns></returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this.StorageList.GetEnumerator();
        }

        #endregion
    }
}
