using ME.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Define
{
    /// <summary>
    /// 程式項目
    /// </summary>
    [Serializable]
    public class GProgramItem : GKeyCollectionItem
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="progID">程式代碼</param>
        public GProgramItem(string progID)
        {
            ProgID = progID;
        }

        /// <summary>
        /// 程式代碼
        /// </summary>
        public string ProgID { get => this.Key; set => this.Key = value; }
        /// <summary>
        /// 顯示名稱
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;
        /// <summary>
        /// 商業邏輯載入物件型別
        /// </summary>
        public GInstanceType BusinessInstanceType { get; set; } = new GInstanceType();
    }
}
