using ME.Base;
using ME.Cahce;
using ME.Define;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ME.Business
{
    /// <summary>
    /// 商業邏輯共用函式。
    /// </summary>
    public class BusinessFunc
    {
        /// <summary>
        /// 建立指定程式代碼的商業邏輯物件。
        /// </summary>
        /// <param name="progID"></param>
        /// <returns></returns>
        public static IBusinessLogic CreateBusinessLogic(string progID)
        {
            var progSetting = CacheFunc.GetProgramSetting("HUM");
            var progItem = progSetting.Items[progID];
            if (progItem.BusinessInstanceType.IsEmpty)
                return new GBusinessLogic(progID);
            else
                return DefineFunc.CreateBusinessLogic(progItem.BusinessInstanceType, progID);
        }

        /// <summary>
        /// 建立指定代碼 > 指定資料表的Entity資料列
        /// </summary>
        /// <param name="progID"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static IEntityRow CreateEntityRow(string progID, string tableName)
        {
            var progDefine = CacheFunc.GetProgramDefine("HUM", progID);
            var tableDefine = progDefine.Tables[tableName];
            if (tableDefine.EntityInstanceType.IsEmpty)
                return new GEntityRow();
            else
                return DefineFunc.CreateEntityRow(tableDefine.EntityInstanceType);
        }

        /// <summary>
        /// 建立指定代碼 > 指定資料表 > 指定型別的Entity資料列
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="progID"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static T CreateEntityRow<T>(string progID, string tableName) where T : IEntityRow
        {
            return (T)CreateEntityRow(progID, tableName);
        }
    }
}
