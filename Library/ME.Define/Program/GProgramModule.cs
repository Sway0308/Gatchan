using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 程式模組別。
    /// </summary>
    public class GProgramModule : GKeyCollectionItem
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="moduleID"></param>
        public GProgramModule(string moduleID)
        {
            ModuleID = moduleID;
        }

        /// <summary>
        /// 模組編號編號
        /// </summary>
        public string ModuleID { get => base.Key; set => base.Key = value; }
        /// <summary>
        /// 顯示名稱
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;
        /// <summary>
        /// 程式分類集合
        /// </summary>
        public GProgramCategoryCollection Categories { get; } = new GProgramCategoryCollection();
        /// <summary>
        /// 程式項目集合
        /// </summary>
        public GProgramItemCollection Items { get; } = new GProgramItemCollection();
    }
}
