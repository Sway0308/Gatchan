using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 資料庫清單設定。
    /// </summary>
    public class GDatabaseSettings
    {
        /// <summary>
        /// 資料庫集合。
        /// </summary>
        public GDatabaseItemCollection Items { get; } = new GDatabaseItemCollection();

        /// <summary>
        /// 新增資料庫項目
        /// </summary>
        /// <param name="displayName">顯示名稱</param>
        /// <param name="dbServer">資料庫伺服器</param>
        /// <param name="dbName">資料庫名稱</param>
        /// <param name="loginID">登入帳號</param>
        /// <param name="password">登入密碼</param>
        public void AddDatabaseItem(string displayName, string dbServer, string dbName, string loginID, string password)
        {
            if (StrFunc.SameTextOr(string.Empty, displayName, dbServer, dbName, loginID, password))
                throw new GException("Empty value is not allowed");

            var maxID = this.Items.Max(x => x.ID) + 1;
            this.Items.Add(new GDatabaseItem
            {
                ID = maxID,
                DisplayName = displayName,
                DbServer = dbServer,
                DbName = dbName,
                LoginID = loginID,
                Password = password
            });
        }
    }
}
