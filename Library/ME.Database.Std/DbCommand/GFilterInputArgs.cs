﻿using ME.Define;

namespace ME.Database
{
    /// <summary>
    /// 過濾條件字串輸入參數。
    /// </summary>
    public class GFilterInputArgs
    {
        /// <summary>
        /// 建構式。
        /// </summary>
        /// <param name="helper">資料庫命令輔助類別介面。</param>
        /// <param name="programDefine">程式定義。</param>
        /// <param name="tableName">資料表名稱。</param>
        /// <param name="tableJoinProvider">資料表關連資訊提供者。</param>
        /// <param name="filterItems">資料過濾條件項目集合。</param>
        /// <param name="sessionInfo">存取連線相關資料的輔助類別。</param>
        /// <param name="enableDbParameter">過濾條件是否啟用 DB 參數。</param>
        public GFilterInputArgs(IDbCommandHelper helper, GProgramDefine programDefine, string tableName, GTableJoinProvider tableJoinProvider, GFilterItemCollection filterItems, GSessionInfo sessionInfo, bool enableDbParameter)
        {
            DbCommandHelper = helper;
            ProgramDefine = programDefine;
            TableName = tableName;
            TableJoinProvider = tableJoinProvider;
            FilterItems = filterItems;
            SessionInfo = sessionInfo;
            EnableDbParameter = enableDbParameter;
        }

        /// <summary>
        /// 資料庫命令輔助類別介面。
        /// </summary>
        public IDbCommandHelper DbCommandHelper { get; }

        /// <summary>
        /// 程式定義。
        /// </summary>
        public GProgramDefine ProgramDefine { get; }

        /// <summary>
        /// 資料表名稱。
        /// </summary>
        public string TableName { get; } = string.Empty;

        /// <summary>
        /// 資料表關連資訊提供者。
        /// </summary>
        public GTableJoinProvider TableJoinProvider { get; }

        /// <summary>
        /// 資料過濾條件項目集合。
        /// </summary>
        public GFilterItemCollection FilterItems { get; }

        /// <summary>
        /// 存取連線相關資料的輔助類別。
        /// </summary>
        public GSessionInfo SessionInfo { get; }

        /// <summary>
        /// 過濾條件是否啟用 DB 參數。
        /// </summary>
        public bool EnableDbParameter { get; } = true;
    }
}
