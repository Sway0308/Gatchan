using System;
using ME.Base;

namespace ME.Define
{
    /// <summary>
    /// 公司資料。
    /// </summary>
    [Serializable]
    public class GCompanyInfo
    {
        /// <summary>
        /// 公司編號。
        /// </summary>
        public string CompanyID { get; set; } = string.Empty;

        /// <summary>
        /// 公司名稱。
        /// </summary>
        public string CompanyName { get; set; } = string.Empty;

        /// <summary>
        /// 公司英文名稱。
        /// </summary>
        public string CompanyEngName { get; set; } = string.Empty;

        /// <summary>
        /// 網站逾時登出，即連線逾時時間，以分鐘為單位。
        /// </summary>
        public int SessionTimeout { get; set; } = 0;

        /// <summary>
        /// 公司參數集合。
        /// </summary>
        public GParameterCollection Parameters { get; set; } = new GParameterCollection();
    }
}
