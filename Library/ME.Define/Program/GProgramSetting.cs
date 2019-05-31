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
        /// 程式項目集合
        /// </summary>
        public GProgramItemCollection Items { get; } = new GProgramItemCollection();
    }
}
