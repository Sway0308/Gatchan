using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Database
{
    /// <summary>
    /// 關連欄位對應。
    /// </summary>
    public class GLinkFieldMapping : GKeyCollectionItem
    {
        /// <summary>
        /// 欄位名稱。
        /// </summary>
        public string FieldName
        {
            get { return base.Key; }
            set { base.Key = value; }
        }

        /// <summary>
        /// 資料表別名。
        /// </summary>
        public string TableAlias { get; set; } = string.Empty;

        /// <summary>
        /// 來源欄位名稱。
        /// </summary>
        public string SourceFieldName { get; set; } = string.Empty;
    }
}
