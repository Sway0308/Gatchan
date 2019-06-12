using ME.Base;
using ME.Define;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatTool
{
    public class Program
    {
        /// <summary>
        /// 項目暫存器
        /// </summary>
        private static GItemKeeper ItemKeeper { get; } = new GItemKeeper();
        /// <summary>
        /// 資料庫清單設定輔助器
        /// </summary>
        private static DbSettingHelper DbSettingHelper => ItemKeeper.GetItem(nameof(DbSettingHelper), () => new DbSettingHelper());

        /// <summary>
        /// 程式進入點
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var path = FileFunc.PathCombine(baseDir, SysDefineSettingName.Setting);
            if (!FileFunc.FileExists(path))
            {
                Console.WriteLine($"Set {SysDefineSettingName.APP_Data} Path");
                var result = Console.ReadLine();
                var json = new JObject { { SysDefineSettingName.APP_Data, result } };
                FileFunc.FileWriteAllText(path, json.ToString());
            }

            var setting = JObject.Parse(FileFunc.FileReadAllText(path));
            BaseInfo.AppDataPath = setting.TokenAsString(SysDefineSettingName.APP_Data);
            Console.WriteLine($"{SysDefineSettingName.APP_Data}：{BaseInfo.AppDataPath}");
            FileFunc.DirectoryCheck(BaseInfo.AppDataPath);
            Console.WriteLine("");
            Execute();
        }

        /// <summary>
        /// 執行定義設定
        /// </summary>
        private static void Execute()
        {
            var executing = true;
            while (executing)
            {
                Console.WriteLine("What you want?");
                Console.WriteLine("0:exit, 1:dbsetting");
                var result = Console.ReadLine();
                if (result.SameTextOr("exit", "0"))
                    executing = false;
                else if (result.SameTextOr("dbsetting", "1"))
                    DbSetting();
                else
                    Console.WriteLine("No idea what you want me to do?");
            }
        }

        /// <summary>
        /// 資料庫清單設定
        /// </summary>
        private static void DbSetting()
        {
            DbSettingHelper.Execute();
        }
    }
}
