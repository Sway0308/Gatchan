﻿using ME.Base;
using ME.Define;
using System;
using System.Collections.Generic;
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
            return JsonFunc.JsonToObject<T>(json);
        }

        /// <summary>
        /// 取得程式定義檔案路徑
        /// </summary>
        /// <param name="progID"></param>
        /// <returns></returns>
        public static GProgramDefine GetProgramDefine(string progID)
        {
            return CacheKeeper.GetItem(progID, () => 
                ConvertToDefine<GProgramDefine>(SysDefineSettingName.ProgramDefineFilePath(progID))
            );
        }

        /// <summary>
        /// 取得公司項目設定
        /// </summary>
        /// <returns></returns>
        public static GCompanySettings GetCompanySettings()
        {
            return CacheKeeper.GetItem(nameof(GCompanySettings), () =>
                   ConvertToDefine<GCompanySettings>(SysDefineSettingName.CompanySettingPath));
        }

        /// <summary>
        /// 取得資料庫設定檔案資料表
        /// </summary>
        /// <returns></returns>
        public static GDatabaseSettings GetDatabaseSettings()
        {
            return CacheKeeper.GetItem(nameof(GDatabaseSettings), () =>
                   ConvertToDefine<GDatabaseSettings>(SysDefineSettingName.DbSettingPath));
        }

        /// <summary>
        /// 取得程式設定檔案路徑
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<GProgramSetting> GetProgramSettings()
        {
            InitProgramSetting();
            return CacheKeeper.GetAllItems<GProgramSetting>();
        }

        /// <summary>
        /// 取得程式設定檔案路徑
        /// </summary>
        /// <returns></returns>
        public static GProgramSetting GetProgramSetting()
        {
            InitProgramSetting();
            var result = CacheKeeper.GetItem<GProgramSetting>(nameof(GProgramSetting));
            if (result != null)
                return result;

            ExtractProgramSetting();
            return CacheKeeper.GetItem<GProgramSetting>(nameof(GProgramSetting));
        }

        /// <summary>
        /// 取得程式項目
        /// </summary>
        /// <param name="progID"></param>
        /// <returns></returns>
        public static GProgramItem GetProgramItem(string progID)
        {
            InitProgramSetting();
            var result = CacheKeeper.GetItem<GProgramItem>(progID);
            if (result != null)
                return result;

            return CacheKeeper.GetItem<GProgramItem>(progID);
        }

        /// <summary>
        /// 初始化程式設定
        /// </summary>
        private static void InitProgramSetting()
        {
            if (CacheKeeper.HasItem<GProgramSetting>())
                return;

            ExtractProgramSetting();
        }

        /// <summary>
        /// 展開程式設定
        /// </summary>
        private static void ExtractProgramSetting()
        {
            var progSettings = from f in Directory.EnumerateFiles(SysDefineSettingName.SystemPath, SysDefineSettingName.ProgramSettingName, SearchOption.AllDirectories)
                               select new { Setting = JsonFunc.JsonToObject<GProgramSetting>(FileFunc.FileReadAllText(f)) };
            foreach (var set in progSettings)
            {
                if (!CacheKeeper.HasItem<GProgramSetting>(nameof(GProgramSetting)))
                {
                    CacheKeeper.AddItem(nameof(GProgramSetting), set.Setting);
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
            foreach (GProgramItem progItem in progSetting.Items)
            {
                CacheKeeper.AddItem(progItem.ProgID, progItem);
            }
        }

        /// <summary>
        /// 取得實體資料表定義列舉
        /// </summary>
        /// <param name="progID"></param>
        /// <returns></returns>
        private static void InitDbTableDefines()
        {
            InitProgramSetting();
            var progSettings = CacheKeeper.GetAllItems<GProgramSetting>();
            if (!progSettings.Any())
                return;

            foreach (var progSetting in progSettings)
            {
                var progItems = CacheKeeper.GetAllItems<GProgramItem>();
                foreach (var item in progItems)
                {
                    CacheKeeper.GetItem(item.ProgID, () =>
                        ConvertToDefine<GDbTableDefine>(SysDefineSettingName.DbTableDefineFilePath(item.ProgID))
                    );
                }
            }
        }

        /// <summary>
        /// 取得實體資料表定義列舉
        /// </summary>
        /// <param name="progID"></param>
        /// <returns></returns>
        public static IEnumerable<GDbTableDefine> GetDbTableDefines()
        {
            InitProgramSetting();
            InitDbTableDefines();
            return CacheKeeper.GetAllItems<GDbTableDefine>();
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
