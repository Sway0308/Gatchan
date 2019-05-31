using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 文字項目集合
    /// </summary>
    public class GTextItemCollection : GKeyCollectionBase<GTextItem>
    {
        /// <summary>
        /// 加入文字項目
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void AddItem(string name, string value)
        {
            this.Add(new GTextItem(name, value));
        }
    }
}
