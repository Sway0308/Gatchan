using ME.Base;
using ME.Define;
using System;
using System.Configuration;
using System.IO;
using System.Linq;

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
        public static GProgramDefine GetProgramDefine(string progID)
        {
            var systemID = CacheKeeper.GetItem<string>(progID);
            if (systemID.IsEmpty())
                throw new GException($"No such ProgID:{progID} exists");

            return CacheKeeper.GetItem<GProgramDefine>(progID, () => 
                ConvertToDefine<GProgramDefine>(SysDefineSettingName.ProgramDefinePath(systemID, progID))
            );
        }

        /// <summary>
        /// 取得資料庫設定檔案資料表
        /// </summary>
        /// <returns></returns>
        public static GDatabaseSettings GetDatabaseSettings()
        {
            return ConvertToDefine<GDatabaseSettings>(SysDefineSettingName.DbSettingPath);
        }

        /// <summary>
        /// 取得程式設定檔案路徑
        /// </summary>
        /// <param name="systemID"></param>
        /// <returns></returns>
        public static GProgramSetting GetProgramSetting(string systemID)
        {
            var result = CacheKeeper.GetItem<GProgramSetting>(systemID);
            if (result != null)
                return result;

            ExtractProgramSetting();
            return CacheKeeper.GetItem<GProgramSetting>(systemID);
        }

        /// <summary>
        /// 取得程式項目
        /// </summary>
        /// <param name="progID"></param>
        /// <returns></returns>
        public static GProgramItem GetProgramItem(string progID)
        {
            var result = CacheKeeper.GetItem<GProgramItem>(progID);
            if (result != null)
                return result;

            return CacheKeeper.GetItem<GProgramItem>(progID);
        }

        /// <summary>
        /// 產開程式設定
        /// </summary>
        private static void ExtractProgramSetting()
        {
            var progSettings = from f in Directory.EnumerateFiles(SysDefineSettingName.SystemPath, SysDefineSettingName.ProgramSettingName, SearchOption.AllDirectories)
                               select new { Setting = BaseFunc.JsonToObject<GProgramSetting>(FileFunc.FileReadAllText(f)) };
            foreach (var set in progSettings)
            {
                var currSystemID = set.Setting.SystemID;

                if (!CacheKeeper.HasItem<GProgramSetting>(currSystemID))
                {
                    CacheKeeper.AddItem(currSystemID, set.Setting);
                    ExtractProgramSetting(set.Setting);
                }
            }
        }

        /// <summary>
        /// 展開程式設定的程式項目，快取到快取暫存器
        /// </summary>
        /// <param name="progSetting"></param>
        private static void ExtractProgramSetting(GProgramSetting progSetting)
        {
            var systemID = progSetting.SystemID;
            foreach (var module in progSetting.Modules)
            {
                foreach (var category in module.Categories)
                    CacheProgramItem(systemID, category.Items);

                CacheProgramItem(systemID, module.Items);
            }
        }

        /// <summary>
        /// 將程式項目快取到快取暫存器
        /// </summary>
        /// <param name="systemID"></param>
        /// <param name="progItems"></param>
        private static void CacheProgramItem(string systemID, GProgramItemCollection progItems)
        {
            foreach (var progItem in progItems)
            {
                CacheKeeper.AddItem(progItem.ProgID, systemID);
                CacheKeeper.AddItem(progItem.ProgID, progItem);
            }
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
