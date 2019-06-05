using System;
using System.Collections;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;

namespace ME.Base
{
    /// <summary>
    /// 強型別集合基底類別
    /// </summary>
    /// <typeparam name="T">成員類別。</typeparam>
    public class GCollectionBase<T> : List<T>, ICollectionBase where T : ICollectionItem
    {
        /// <summary>
        /// 建構函式。
        /// </summary>
        public GCollectionBase()
        {}

        /// <summary>
        /// 建構函式。
        /// </summary>
        /// <param name="owner">擁有者。</param>
        public GCollectionBase(object owner)
        {
            this.Owner = owner;
        }

        /// <summary>
        ///  擁有者。
        /// </summary>
        public virtual object Owner { get; }

        /// <summary>
        /// 依索引取得成員。
        /// </summary>
        /// <param name="index">索引。</param>
        public object GetItem(int index)
        {
            return base[index];
        }

        /// <summary>
        /// 移除成員。
        /// </summary>
        /// <param name="item"></param>
        public new void Remove(T item)
        {
            OnRemove(item);
            base.Remove(item);
        }

        /// <summary>
        /// 新增成員
        /// </summary>
        /// <param name="item"></param>
        public new virtual void Add(T item)
        {
            OnAdd(item);
            base.Add(item);
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
    }
}
