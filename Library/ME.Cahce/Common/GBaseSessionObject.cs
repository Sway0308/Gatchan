using System;
using ME.Base;
using ME.Cahce;
using ME.Define;

namespace ME.Cache
{
    /// <summary>
    /// 具有連線資訊的元件基底類別。
    /// </summary>
    public abstract class GBaseSessionObject
    {
        private GSessionInfo _SessionInfo;

        #region 建構函式

        /// <summary>
        /// 建構函式。
        /// </summary>
        /// <param name="sessionGuid">連線識別。</param>
        public GBaseSessionObject(Guid sessionGuid)
        {
            SessionGuid = sessionGuid;
        }

        #endregion

        /// <summary>
        /// 連線識別。
        /// </summary>
        public Guid SessionGuid { get; } = Guid.Empty;

        /// <summary>
        /// 連線資訊。
        /// </summary>
        public GSessionInfo SessionInfo
        {
            get
            { 
                if (BaseFunc.IsNull(_SessionInfo))
                    _SessionInfo = CacheFunc.GetSessionInfo(this.SessionGuid);
                return _SessionInfo;
            }
        }
    }
}
