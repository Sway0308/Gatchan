using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 公司項目
    /// </summary>
    public class GCompanyItem : GKeyCollectionItem
    {
        /// <summary>
        /// 公司編號
        /// </summary>
        public string CompanyID { get => base.Key; set => base.Key = value; }
        /// <summary>
        /// 資料庫編號
        /// </summary>
        public string DatabaseID { get; set; }
        /// <summary>
        /// 顯示名稱
        /// </summary>
        public string DisplayName { get; set; }
    }
}
