using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Base
{
    /// <summary>
    /// 含鍵值的集合型成員基底類別
    /// </summary>
    public class GKeyCollectionItem : IKeyCollectionItem
    {
        /// <summary>
        /// 主鍵
        /// </summary>
        [JsonIgnore]
        public string Key { get; set; }

        /// <summary>
        /// 集合母體
        /// </summary>
        [JsonIgnore]
        protected IKeyCollectionBase Collection { get; private set; }

        /// <summary>
        /// 設定集合母體
        /// </summary>
        /// <param name="collection"></param>
        public void SetCollection(IKeyCollectionBase collection)
        {
            this.Collection = collection;
        }
    }
}
