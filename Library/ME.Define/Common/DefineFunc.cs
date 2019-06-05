using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ME.Base;
using System.Data;

namespace ME.Define
{
    /// <summary>
    /// 定義函式
    /// </summary>
    public class DefineFunc
    {
        /// <summary>
        /// 程式定義轉資料表定義
        /// </summary>
        /// <param name="progDefine"></param>
        /// <returns></returns>
        public static IEnumerable<GDbTableDefine> ProgDefineToDbTableDefine(GProgramDefine progDefine)
        {
            foreach (GTableDefine tableDefine in progDefine.Tables)
            {
                var dbDefine = new GDbTableDefine { TableName = tableDefine.TableName, DisplayName = tableDefine.DisplayName };
                foreach (var field in tableDefine.Fields.Where(x => x.FieldType == Base.EFieldType.DataField))
                    dbDefine.Fields.Add(new GDbFieldDefine(field));
                yield return dbDefine;
            }
        }

        /// <summary>
        /// 動態建立功能層級商業邏輯物件。
        /// </summary>
        /// <param name="assemblyFile">組件檔案名稱。</param>
        /// <param name="typeName">類別名稱。</param>
        /// <param name="sessionGuid">連線識別。</param>
        /// <param name="progID">程式代碼。</param>
        private static IBusinessLogic CreateBusinessLogic(string assemblyFile, string typeName, Guid sessionGuid, string progID)
        {
            //取得組件的完整路徑
            var sAssemblyFile = FileFunc.PathCombine(FileFunc.GetAssemblyPath(), assemblyFile);
            //動態載入組件，建立指定類別的物件
            var oAssemblyLoader = new GAssemblyLoader(sAssemblyFile);
            return (IBusinessLogic)oAssemblyLoader.CreateInstance(typeName, new object[] { sessionGuid, progID });
        }

        /// <summary>
        /// 動態建立功能層級商業邏輯物件。
        /// </summary>
        /// <param name="instanceType">動態載入物件的型別描述。</param>
        /// <param name="sessionGuid">連線識別。</param>
        /// <param name="progID">程式代碼。</param>
        public static IBusinessLogic CreateBusinessLogic(GInstanceType instanceType, Guid sessionGuid, string progID)
        {
            return CreateBusinessLogic(instanceType.AssemblyFile, instanceType.TypeName, sessionGuid, progID);
        }

        /// <summary>
        /// 依資料表定義建立 DataTable。
        /// </summary>
        /// <param name="tableDefine">資料表定義。</param>
        public static DataTable CreateDataTable(GTableDefine tableDefine)
        {
            var helper = new GDataTableHelper(tableDefine.TableName);
            foreach (GFieldDefine fieldDefine in tableDefine.Fields)
                helper.AddColumn(fieldDefine.FieldName, fieldDefine.DbType, GetDefaultValue(fieldDefine));
            return helper.DataTable;
        }

        /// <summary>
        /// 取得欄位預設值(字串預設為空字串、數值預設為 0，布林值預設為 false，其他為 DBNull.Value)。
        /// </summary>
        /// <param name="fieldDefine">欄位定義。</param>
        public static object GetDefaultValue(GFieldDefine fieldDefine)
        {
            if (fieldDefine.AllowNull)
                return DBNull.Value;
            else
                return DataFunc.GetDefaultValue(fieldDefine.DbType);
        }

        /// <summary>
        /// 動態建立 Entity 資料列。
        /// </summary>
        /// <param name="instanceType">動態載入物件的型別描述。</param>
        /// <returns></returns>
        public static GEntityRow CreateEntityRow(GInstanceType instanceType)
        {
            //取得組件的完整路徑
            var assemblyFilePath = FileFunc.PathCombine(FileFunc.GetAssemblyPath(), instanceType.AssemblyFile);
            //動態載入組件，建立指定類別的物件
            var assemblyLoader = new GAssemblyLoader(assemblyFilePath);
            return (GEntityRow)assemblyLoader.CreateInstance(instanceType.TypeName, new object[] { });
        }
    }
}
