﻿using ME.Base;
using ME.Setting;
using System;

namespace GatTool
{
    /// <summary>
    /// 資料庫清單設定輔助器
    /// </summary>
    public class DbSettingHelper
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="defineFileHelper"></param>
        public DbSettingHelper(GDefineFileHelper defineFileHelper)
        {
            DefineFileHelper = defineFileHelper;
        }

        /// <summary>
        /// 定義檔案設定輔助器
        /// </summary>
        private GDefineFileHelper DefineFileHelper { get; } = new GDefineFileHelper();

        /// <summary>
        /// 執行
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Into Database Setting");
            var executing = true;
            while (executing)
            {
                Console.WriteLine("What you want?");
                Console.WriteLine("0:exit, 1:view, 2:add, 3:edit, 4:delete");
                var result = Console.ReadLine();
                if (result.SameTextOr("exit", "0"))
                    executing = false;
                else if (result.SameTextOr("view", "1"))
                    View();
                else if (result.SameTextOr("add", "2"))
                    Add();
                else if (result.SameTextOr("edit", "3"))
                    Edit();
                else if (result.SameTextOr("delete", "4"))
                    Delete();
                else
                    Console.WriteLine("No idea what you want me to do?");

                Console.WriteLine();
            }
        }

        /// <summary>
        /// 檢視
        /// </summary>
        private void View()
        {
            var json = JsonFunc.ObjectToJson(this.DefineFileHelper.DatabaseSettings);
            Console.WriteLine("=====================");
            Console.WriteLine(json);
            Console.WriteLine("=====================");
            Console.WriteLine("Continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// 新增
        /// </summary>
        private void Add()
        {
            Console.WriteLine("Start add database item");
            var executing = true;
            while (executing)
            {
                DoAdd();
                Console.WriteLine("Keep adding database item? Yes/No");
                var ans = Console.ReadLine();
                if (!ans.SameTextOr("Y", "Yes"))
                    executing = false;
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 新增 的實作
        /// </summary>
        private void DoAdd()
        {
            Console.WriteLine("DisplayName：");
            var displayName = Console.ReadLine();
            Console.WriteLine("Db Server：");
            var dbServer = Console.ReadLine();
            Console.WriteLine("Db Name：");
            var dbName = Console.ReadLine();
            Console.WriteLine("Login ID：");
            var loginID = Console.ReadLine();
            Console.WriteLine("Password：");
            var password = Console.ReadLine();

            var ans = Console.ReadLine();
            if (ans.SameTextOr("Y", "Yes"))
            {
                this.DefineFileHelper.AddDbSettingItem(displayName, dbServer, dbName, loginID, password);
                Console.WriteLine("Add database item success");
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        private void Edit()
        { }

        /// <summary>
        /// 刪除
        /// </summary>
        private void Delete()
        { }
    }
}
