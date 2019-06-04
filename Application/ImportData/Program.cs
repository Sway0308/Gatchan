using ME.Base;
using ME.Cahce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseInfo.AppDataPath = @"C:\Users\SCSRD\Documents\GitHub\Gatchan\Application\APP_Data";
            MechanismDemo();
        }

        private static void ReSaveProgramDefine()
        {
            var helper = new InitDataHelper();
            var pd = CacheFunc.GetProgramDefine("HUM", "SalaryAccount");
            helper.ProgDefineToJson(pd);
            pd = CacheFunc.GetProgramDefine("HUM", "SalaryAccountCategory");
            helper.ProgDefineToJson(pd);
            pd = CacheFunc.GetProgramDefine("HUM", "SalaryAccountForSalaryRange");
            helper.ProgDefineToJson(pd);
            pd = CacheFunc.GetProgramDefine("HUM", "SalaryRange");
            helper.ProgDefineToJson(pd);
        }

        /// <summary>
        /// 建立程式定義
        /// </summary>
        private static void CreateProgramDefine()
        {
            var helper = new ProgramDefineHelper();
            helper.CreateProgramDefine();
        }

        /// <summary>
        /// 機制Demo
        /// </summary>
        private static void MechanismDemo()
        {
            var helper = new InitDataHelper();

            Console.WriteLine("定義匯入");
            Console.ReadKey();
            helper.InitData();
            Console.WriteLine("定義匯入完成");
            Console.WriteLine("==================================");

            Console.WriteLine("資料表升級");
            Console.ReadKey();
            helper.CreateDbTable();
            Console.WriteLine("資料表完成");
            Console.WriteLine("==================================");

            Console.WriteLine("新增資料");
            Console.ReadKey();
            helper.AddData();
            Console.WriteLine("新增資料完成");
            Console.WriteLine("==================================");

            Console.WriteLine("查詢資料");
            Console.ReadKey();
            helper.FindData();
            Console.WriteLine("查詢資料完成");
            Console.WriteLine("==================================");

            Console.WriteLine("修改資料");
            Console.ReadKey();
            helper.EditData();
            Console.WriteLine("修改資料完成");
            Console.WriteLine("==================================");

            Console.WriteLine("刪除資料");
            Console.ReadKey();
            helper.DeleteData();
            Console.WriteLine("刪除資料完成");
            Console.WriteLine("==================================");

            Console.WriteLine("離開");
            Console.ReadKey();
        }
    }
}
