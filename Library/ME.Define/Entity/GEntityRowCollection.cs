using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// Entity 資料列集合
    /// </summary>
    public class GEntityRowCollection : GCollectionBase<GEntityRow>
    {
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <param name="value"></param>
        protected override void OnRemove(ICollectionItem value)
        {
            (value as GEntityRow).SetRowState(EEntityRowState.Deleted);
            base.OnRemove(value);
        }
    }
}
