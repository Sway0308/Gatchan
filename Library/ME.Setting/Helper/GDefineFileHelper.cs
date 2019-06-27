﻿using ME.Cahce;
using ME.Define;
using System;
using System.Collections.Generic;

namespace ME.Setting
{
    /// <summary>
    /// 定義檔案輔助器
    /// </summary>
    public class GDefineFileHelper
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public GDefineFileHelper()
        {
            this.DatabaseSettings = CacheFunc.GetDatabaseSettings();
            this.CompanySettings = CacheFunc.GetCompanySettings();
            this.ProgramSettings = CacheFunc.GetProgramSettings();
        }

        /// <summary>
        /// 資料表定義
        /// </summary>
        public GDatabaseSettings DatabaseSettings { get; }
        /// <summary>
        /// 公司定義
        /// </summary>
        public GCompanySettings CompanySettings { get; }
        /// <summary>
        /// 程式項目定義列舉
        /// </summary>
        public IEnumerable<GProgramSetting> ProgramSettings { get; }

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
            this.DatabaseSettings.AddDatabaseItem(displayName, dbServer, dbName, loginID, password);
        }

        /// <summary>
        /// 新增資料庫項目
        /// </summary>
        /// <param name="item">資料庫設定項目</param>
        public void AddDbSettingItem(GDatabaseItem item)
        {
            this.DatabaseSettings.Items.Add(item);
        }
    }
}
