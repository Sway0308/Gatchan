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
        protected override void OnRemove(GEntityRow value)
        {
            (value as GEntityRow).SetRowState(EEntityRowState.Deleted);
            base.OnRemove(value);
        }

        /// <summary>
        /// 認可自上次對此資料表的所有變更
        /// </summary>
        public void AcceptChanges()
        {
            foreach (var row in this.Where(x => x.RowState == EEntityRowState.Deleted))
                row.Remove();

            foreach (var row in this)
                row.SetRowState(EEntityRowState.Unchanged);
        }
    }
}
