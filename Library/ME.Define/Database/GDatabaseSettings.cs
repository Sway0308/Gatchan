using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 資料庫清單設定。
    /// </summary>
    public class GDatabaseSettings
    {
        /// <summary>
        /// 資料庫集合。
        /// </summary>
        public GDatabaseItemCollection Items { get; } = new GDatabaseItemCollection();
    }
}
