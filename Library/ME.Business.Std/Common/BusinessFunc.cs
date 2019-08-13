using ME.Base;
using ME.Cahce;
using ME.Define;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static IBusinessLogic CreateBusinessLogic(Guid sessionGuid, string progID)
        {
            var progItem = CacheFunc.GetProgramItem(progID);
            if (progItem.BusinessInstanceType.IsEmpty)
                return new GBusinessLogic(sessionGuid, progID);
            else
                return DefineFunc.CreateBusinessLogic(progItem.BusinessInstanceType, sessionGuid, progID);
        }

        /// <summary>
        /// 建立指定代碼 > 指定資料表的Entity資料列
        /// </summary>
        /// <param name="progID"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static GEntityRow CreateEntityRow(string progID, string tableName)
        {
            var progDefine = CacheFunc.GetProgramDefine(progID);
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
        public static T CreateEntityRow<T>(string progID, string tableName) where T : GEntityRow
        {
            return (T)CreateEntityRow(progID, tableName);
        }

        /// <summary>
        /// 設定資料表中每個欄位的預設值。
        /// </summary>
        /// <param name="tableDefine">資料表定義。</param>
        /// <param name="dataTable">資料表。</param>
        public static void SetDataColumnDefaultValue(GTableDefine tableDefine, DataTable dataTable)
        {
            foreach (DataColumn oColumn in dataTable.Columns)
            {
                var oFieldDefine = tableDefine.Fields[oColumn.ColumnName];
                if (BaseFunc.IsNotNull(oFieldDefine) && !oFieldDefine.AllowNull)
                {
                    oColumn.DefaultValue = DataFunc.GetDefaultValue(oFieldDefine.DbType);
                }
            }
        }
    }
}
