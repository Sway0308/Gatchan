using ME.Cahce;
using ME.Database;

namespace ME.Business
{
    /// <summary>
    /// 具有連線資訊及資料庫存取的元件基底類別。
    /// </summary>
    public class GBaseDbAccess
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public GBaseDbAccess()
        {
            var dbSetting = CacheFunc.GetDatabaseSettings();
            this.DbAccess = new GDbAccess(dbSetting);
        }
        
        /// <summary>
        /// 資料庫存取物件。
        /// </summary>
        public GDbAccess DbAccess { get; }
    }
}