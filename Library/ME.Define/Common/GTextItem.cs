using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 文字項目暫存物件
    /// </summary>
    public class GTextItem : GKeyCollectionItem
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public GTextItem(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// 項目名稱
        /// </summary>
        public string Name { get => base.Key; set => base.Key = value; }
        /// <summary>
        /// 項目值
        /// </summary>
        public string Value { get; set; }
    }
}
