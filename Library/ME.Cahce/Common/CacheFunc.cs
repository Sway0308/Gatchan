using ME.Base;
using ME.Define;
using System;
using System.Configuration;

namespace ME.Cahce
{
    /// <summary>
    /// 快取相關函式庫。
    /// </summary>
    public class CacheFunc
    {
        /// <summary>
        /// 快取暫存器
        /// </summary>
        private static GItemKeeper CacheKeeper { get; } = new GItemKeeper();

        /// <summary>
        /// 取得應用程式資料路徑，伺服端及用戶端應用程式皆適用。
        /// </summary>
        /// <remarks>
        /// 1. 先判斷 BaseInfo.AppDataPath 是否有自訂應用程式資料路徑。
        /// 2. 上一條件不符合，再判斷應用程式組態檔的 AppSettings 區段是是有設定 AppDataPath。
        /// 3. 上一條件不符合，則預設置於 "應用程式 App_Data 的資料夾下。
        /// </remarks>
        public static string GetAppDataPath()
        {
            // 1. 先判斷 BaseInfo.AppDataPath 是否有自訂應用程式資料路徑
            if (StrFunc.StrIsNotEmpty(BaseInfo.AppDataPath))
                return BaseInfo.AppDataPath;

            // 2. 上一條件不符合，再判斷應用程式組態檔的 AppSettings 區段是是有設定 AppDataPath
            var appDataPath = ConfigurationManager.AppSettings["AppDataPath"];
            if (StrFunc.StrIsNotEmpty(appDataPath))
            {
                BaseInfo.AppDataPath = appDataPath;
                return BaseInfo.AppDataPath;
            }

            // 3. 上一條件不符合，則預設置於 "應用程式 App_Data 的資料夾下
            BaseInfo.AppDataPath = FileFunc.GetAppPath("App_Data");
            return BaseInfo.AppDataPath;
        }

        /// <summary>
        /// json檔案轉型為定義
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static T ConvertToDefine<T>(string filePath)
        {
            var json = FileFunc.FileReadAllText(filePath);
            return BaseFunc.JsonToObject<T>(json);
        }

        /// <summary>
        /// 取得程式定義檔案路徑
        /// </summary>
        /// <param name="systemID"></param>
        /// <param name="progID"></param>
        /// <returns></returns>
        public static GProgramDefine GetProgramDefine(string systemID, string progID)
        {
            return CacheKeeper.GetItem<GProgramDefine>(progID, () => {
                var programDefinePath = FileFunc.PathCombine(GetAppDataPath(), $@"Common\{systemID}\ProgramDefine");
                var filePath = FileFunc.PathCombine(programDefinePath, $"{progID}.ProgramDefine.json");
                return ConvertToDefine<GProgramDefine>(filePath);
            });
        }

        /// <summary>
        /// 取得資料庫設定檔案資料表
        /// </summary>
        /// <returns></returns>
        public static GDatabaseSettings GetDatabaseSettings()
        {
            var filePath = FileFunc.PathCombine(GetAppDataPath(), "DatabaseSettings.json");
            return ConvertToDefine<GDatabaseSettings>(filePath);
        }

        /// <summary>
        /// 取得程式設定檔案路徑
        /// </summary>
        /// <param name="systemID"></param>
        /// <returns></returns>
        public static GProgramSetting GetProgramSetting(string systemID)
        {
            return CacheKeeper.GetItem<GProgramSetting>(systemID, () => {
                var modulePath = FileFunc.PathCombine(GetAppDataPath(), $@"Common\{systemID}");
                var filePath = FileFunc.PathCombine(modulePath, "ProgramSetting.json");
                return ConvertToDefine<GProgramSetting>(filePath);
            });

        }

        /// <summary>
        /// 由快取區取得程式定義。
        /// </summary>
        /// <param name="sessionGuid">連線識別</param>
        /// <param name="progID">程式代碼。</param>
        public static GSessionInfo GetSessionInfo(Guid sessionGuid)
        {
            return CacheKeeper.GetItem<GSessionInfo>(sessionGuid.ToString(), () => new GSessionInfo { SessionGuid = sessionGuid });
        }
    }
}
