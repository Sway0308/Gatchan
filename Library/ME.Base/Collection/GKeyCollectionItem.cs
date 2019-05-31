using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Base
{
    /// <summary>
    /// 含鍵值的集合型成員基底類別
    /// </summary>
    public class GKeyCollectionItem
    {
        /// <summary>
        /// 主鍵
        /// </summary>
        [JsonIgnore]
        public string Key { get; set; }
    }
}
