using ME.Base;
using ME.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatTool
{
    /// <summary>
    /// 資料庫清單設定輔助器
    /// </summary>
    public class DbSettingHelper
    {
        /// <summary>
        /// 資料庫連線設定輔助器
        /// </summary>
        private GDbSettingHelper Helper { get; } = new GDbSettingHelper();

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
            }
        }

        /// <summary>
        /// 檢視
        /// </summary>
        private void View()
        {
            var json = this.Helper.GetSettingJson();
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
        { }

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
