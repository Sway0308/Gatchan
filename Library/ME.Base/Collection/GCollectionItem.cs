using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ME.Base
{
    /// <summary>
    /// 強型別集合成員基礎類別。
    /// </summary>
    public class GCollectionItem : ICollectionItem
    {
        #region 建構函式

        /// <summary>
        /// 建構函式。
        /// </summary>
        public GCollectionItem()
        {
            Collection = null;
        }

        #endregion

        #region ICollectionItem 介面

        /// <summary>
        /// 設定所屬集合。
        /// </summary>
        /// <param name="collection">集合。</param>
        public void SetCollection(ICollectionBase collection)
        {
            Collection = collection;
        }

        #endregion

        /// <summary>
        /// 所屬集合。
        /// </summary>
        protected ICollectionBase Collection { get; private set; } = null;
    }
}
