using ME.Cahce;
using ME.Database;
using ME.Define;
using System;

namespace ME.Business
{
    /// <summary>
    /// 具有連線資訊及資料庫存取的元件基底類別。
    /// </summary>
    public class GBaseDbAccess
    {
        private GSessionInfo _SessionInfo;

        /// <summary>
        /// 建構函式
        /// </summary>
        public GBaseDbAccess(Guid sessionGuid)
        {
            var dbSetting = CacheFunc.GetDatabaseSettings();
            this.DbAccess = new GDbAccess(dbSetting);
        }

        /// <summary>
        /// 資料庫存取物件。
        /// </summary>
        public GDbAccess DbAccess { get; }

        /// <summary>
        /// 連線識別
        /// </summary>
        public Guid SessionGuid { get; }

        /// <summary>
        /// 連線資訊
        /// </summary>
        public GSessionInfo SessionInfo
        {
            get
            {
                if (_SessionInfo == null)
                    _SessionInfo = CacheFunc.GetSessionInfo(this.SessionGuid);
                return _SessionInfo;
            }
        }
    }
}