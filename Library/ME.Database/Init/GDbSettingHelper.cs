using ME.Base;
using ME.Define;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Database
{
    /// <summary>
    /// 資料庫連線設定輔助器
    /// </summary>
    public class GDbSettingHelper : GBaseSettingHelper<GDatabaseSettings>
    {
        /// <summary>
        /// 資料庫定義檔設定路徑
        /// </summary>
        protected override string SettingFilePath => FileFunc.PathCombine(BaseInfo.AppDataPath, SysDefineSettingName.DbSettingName);

        /// <summary>
        /// 新增資料庫項目
        /// </summary>
        /// <param name="displayName">顯示名稱</param>
        /// <param name="dbServer">資料庫伺服器</param>
        /// <param name="dbName">資料庫名稱</param>
        /// <param name="loginID">登入帳號</param>
        /// <param name="password">登入密碼</param>
        public void AddDbSettingItem(string displayName, string dbServer, string dbName, string loginID, string password)
        {
            this.Define.AddDatabaseItem(displayName, dbServer, dbName, loginID, password);
        }

        /// <summary>
        /// 新增資料庫項目
        /// </summary>
        /// <param name="item">資料庫設定項目</param>
        public void AddDbSettingItem(GDatabaseItem item)
        {
            this.Define.Items.Add(item);
        }
    }
}
