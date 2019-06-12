using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ME.Define
{
    /// <summary>
    /// 程式設定
    /// </summary>
    public class GProgramSetting
    {
        /// <summary>
        /// 系統代號
        /// </summary>
        public string SystemID { get; set; }
        /// <summary>
        /// 顯示名稱
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 程式模組別集合
        /// </summary>
        public GProgramModuleCollection Modules { get; } = new GProgramModuleCollection();
    }
}
