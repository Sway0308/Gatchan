using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ME.Define
{
    /// <summary>
    /// 程式設定
    /// </summary>
    public class GProgramSetting : ISystemDefine
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="systemID"></param>
        public GProgramSetting(string systemID)
        {
            SystemID = systemID;
        }

        /// <summary>
        /// 取得定義檔案路徑
        /// </summary>
        /// <returns></returns>
        public string GetDefineFilePath()
        {
            return SysDefineSettingName.ProgramSettingFilePath(this.SystemID);
        }

        /// <summary>
        /// 系統代號
        /// </summary>
        public string SystemID { get; set; }
        /// <summary>
        /// 顯示名稱
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 程式項目
        /// </summary>
        public GProgramItemCollection Items { get; set; } = new GProgramItemCollection();
    }
}
