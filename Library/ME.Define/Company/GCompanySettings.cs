using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 公司項目設定
    /// </summary>
    public class GCompanySettings : IDefineFile
    {
        /// <summary>
        /// 定義檔案路徑
        /// </summary>
        /// <returns></returns>
        public string GetDefineFilePath()
        {
            return SysDefineSettingName.CompanySettingPath;
        }

        /// <summary>
        /// 公司清單集合。
        /// </summary>
        public GCompanyItemCollection Items { get; } = new GCompanyItemCollection();
    }
}
