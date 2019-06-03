using ME.Base;
using ME.Cahce;
using ME.Database;
using ME.Define;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ME.Business
{
    /// <summary>
    /// 功能層級商業邏輯元件
    /// </summary>
    public class GBusinessLogic : GBaseBusinessLogic, IBusinessLogic
    {
        private class ATableJoin
        {
            public ATableJoin(string tableName, string dbTableName, string aliasName)
            {
                TableName = tableName;
                DbTableName = dbTableName;
                AliasName = aliasName;
            }

            public string TableName { get; set; }
            public string DbTableName { get; set; }
            public string AliasName { get; set; }
        }

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="progID"></param>
        public GBusinessLogic(Guid sessionGuid, string progID) : base(sessionGuid, progID)
        {
        }

        /// <summary>
        /// 新增表單資料。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <returns></returns>
        public GAddOutputResult Add(GAddInputArgs inputArgs)
        {
            var outputResult = new GAddOutputResult();

            DoBeforeAdd(inputArgs, outputResult);
            if (inputArgs.Cancel) { return outputResult; }

            DoAdd(inputArgs, outputResult);

            DoAfterAdd(inputArgs, outputResult);

            return outputResult;
        }

        /// <summary>
        /// 執行 Add 方法後呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoBeforeAdd(GAddInputArgs inputArgs, GAddOutputResult outputResult)
        {

        }

        /// <summary>
        /// 執行 Add 方法的實作。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoAdd(GAddInputArgs inputArgs, GAddOutputResult outputResult)
        {
            var table = DefineFunc.CreateDataTable(this.ProgramDefine.MasterTable);
            var dataSet = DataFunc.CreateDataSet(this.ProgID);
            dataSet.Tables.Add(table);
            table.Rows.Add(table.NewRow());
            outputResult.DataSet = dataSet;
        }

        /// <summary>
        /// 執行 Add 方法前呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoAfterAdd(GAddInputArgs inputArgs, GAddOutputResult outputResult)
        {

        }

        /// <summary>
        /// 刪除表單資料。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <returns></returns>
        public GDeleteOutputResult Delete(GDeleteInputArgs inputArgs)
        {
            var outputResult = new GDeleteOutputResult();

            DoBeforeDelete(inputArgs, outputResult);
            if (inputArgs.Cancel) { return outputResult; }
                        
            DoDelete(inputArgs, outputResult);            

            DoAfterDelete(inputArgs, outputResult);

            return outputResult;
        }

        /// <summary>
        /// 執行 Delete 方法前呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoBeforeDelete(GDeleteInputArgs inputArgs, GDeleteOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 執行 Delete 方法的實作。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoDelete(GDeleteInputArgs inputArgs, GDeleteOutputResult outputResult)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Delete A");
            sql.AppendLine($"From {this.ProgID} A");
            sql.AppendLine($"Where A.{this.ProgID}ID = {inputArgs.FormID.SQLStr()}");
            this.DbAccess.ExecuteNonQuery(this.DatabaseID, sql.ToString());
        }

        /// <summary>
        /// 執行 Delete 方法後呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoAfterDelete(GDeleteInputArgs inputArgs, GDeleteOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 編輯表單資料。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <returns></returns>
        public GEditOutputResult Edit(GEditInputArgs inputArgs)
        {
            var outputResult = new GEditOutputResult();

            DoBeforeEdit(inputArgs, outputResult);
            if (inputArgs.Cancel) { return outputResult; }

            DoEdit(inputArgs, outputResult);

            DoAfterEdit(inputArgs, outputResult);

            return outputResult;
        }

        /// <summary>
        /// 執行 Edit 方法前呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoBeforeEdit(GEditInputArgs inputArgs, GEditOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 執行 Edit 方法的實作。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoEdit(GEditInputArgs inputArgs, GEditOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 執行 Edit 方法後呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoAfterEdit(GEditInputArgs inputArgs, GEditOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 執行自訂方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <returns></returns>
        public GExecFuncOutputResult ExecFunc(GExecFuncInputArgs inputArgs)
        {
            var outputResult = new GExecFuncOutputResult();
            DoExecFunc(inputArgs, outputResult);
            return outputResult;
        }

        /// <summary>
        /// 自訂方法實作。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoExecFunc(GExecFuncInputArgs inputArgs, GExecFuncOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 查詢清單資料。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <returns></returns>
        public GFindOutputResult Find(GFindInputArgs inputArgs)
        {
            var outputResult = new GFindOutputResult();

            DoBeforeFind(inputArgs, outputResult);
            if (inputArgs.Cancel) { return outputResult; }

            DoFind(inputArgs, outputResult);

            DoAfterFind(inputArgs, outputResult);

            return outputResult;
        }

        /// <summary>
        /// 執行 Find 方法前呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoBeforeFind(GFindInputArgs inputArgs, GFindOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 執行 Find 方法的實作。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoFind(GFindInputArgs inputArgs, GFindOutputResult outputResult)
        {
            var selectArgs = new GSelectInputArgs { FilterItems = inputArgs.FilterItems };
            var selectResult = Select(selectArgs);
            outputResult.EntityTable = selectResult.EntityTable;
        }

        /// <summary>
        /// 執行 Find 方法後呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoAfterFind(GFindInputArgs inputArgs, GFindOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 取得指定內碼的表單資料。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <returns></returns>
        public GMoveOutputResult Move(GMoveInputArgs inputArgs)
        {
            var outputResult = new GMoveOutputResult();

            DoBeforeMove(inputArgs, outputResult);
            if (inputArgs.Cancel) { return outputResult; }

            DoMove(inputArgs, outputResult);

            DoAfterMove(inputArgs, outputResult);

            return outputResult;
        }

        /// <summary>
        /// 執行 Move 方法前呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoBeforeMove(GMoveInputArgs inputArgs, GMoveOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 執行 Move 方法的實作。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoMove(GMoveInputArgs inputArgs, GMoveOutputResult outputResult)
        {
            outputResult.EntitySet = new GEntitySet(this.ProgID);
            foreach (var tableDefine in this.ProgramDefine.Tables)
            {
                var selectArgs = new GSelectInputArgs { FilterItems = { new GFilterItem($"{this.ProgID}ID", inputArgs.FormID) } };
                var selectResult = Select(selectArgs);
                outputResult.EntitySet.Tables.Add(selectResult.EntityTable);
            }
        }

        /// <summary>
        /// 執行 Move 方法後呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoAfterMove(GMoveInputArgs inputArgs, GMoveOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 儲存表單資料。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <returns></returns>
        public GSaveOutputResult Save(GSaveInputArgs inputArgs)
        {
            var outputResult = new GSaveOutputResult();

            DoBeforeSave(inputArgs, outputResult);
            if (inputArgs.Cancel) { return outputResult; }

            DoSave(inputArgs, outputResult);

            DoAfterSave(inputArgs, outputResult);

            return outputResult;
        }

        /// <summary>
        /// 執行 Save 方法前呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoBeforeSave(GSaveInputArgs inputArgs, GSaveOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 執行 Save 方法的實作。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoSave(GSaveInputArgs inputArgs, GSaveOutputResult outputResult)
        {
            var table = inputArgs.DataSet.Tables[this.ProgID];
            if (inputArgs.SaveMode == ESaveMode.Add)
            {
                foreach (DataRow row in table.Rows)
                {
                    var sql = new StringBuilder();
                    sql.AppendLine($"Insert Into {this.ProgID} (");
                    var isFirst = true;
                    foreach (var fieldDefine in this.ProgramDefine.MasterFields.Where(x => x.FieldType == EFieldType.DataField))
                    {
                        var fieldName = fieldDefine.FieldName;
                        sql.AppendLine((isFirst ? "" : ",") + $"{fieldName}");
                        isFirst = false;
                    }
                    sql.AppendLine(")");
                    sql.AppendLine("Values (");
                    isFirst = true;
                    foreach (var fieldDefine in this.ProgramDefine.MasterFields.Where(x => x.FieldType == EFieldType.DataField))
                    {
                        var fieldName = fieldDefine.FieldName;
                        if (DataFunc.HasField(row, fieldName))
                        {
                            sql.AppendLine((isFirst ? "" : ",") + $"{row.ValueAsSQLStr(fieldName)}");
                            isFirst = false;
                        }
                    }
                    sql.AppendLine(")");
                    this.DbAccess.ExecuteNonQuery(this.DatabaseID, sql.ToString());
                }
            }
            else
            {
                foreach (DataRow row in table.Rows)
                {
                    var sql = new StringBuilder();
                    sql.AppendLine("Update A Set");
                    var isFirst = true;
                    foreach (var fieldDefine in this.ProgramDefine.MasterFields.Where(x => x.FieldType == EFieldType.DataField))
                    {
                        var fieldName = fieldDefine.FieldName;
                        if (DataFunc.HasField(row, fieldName) && !fieldName.SameText($"{this.ProgID}ID"))
                        {
                            sql.AppendLine((isFirst ? "" : ",") + $"{fieldName} = {row.ValueAsSQLStr(fieldName)}");
                            isFirst = false;
                        }
                    }
                    sql.AppendLine($"From {this.ProgID} A");
                    sql.AppendLine($"Where A.{this.ProgID}ID = {row.ValueAsSQLStr($"{this.ProgID}ID")}");
                    this.DbAccess.ExecuteNonQuery(this.DatabaseID, sql.ToString());
                }
            }
        }

        /// <summary>
        /// 執行 Save 方法後呼叫的方法。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoAfterSave(GSaveInputArgs inputArgs, GSaveOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 取得指定資料表符合條件的資料。
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <returns></returns>
        public GSelectOutputResult Select(GSelectInputArgs inputArgs)
        {
            var outputResult = new GSelectOutputResult();

            DoBeforeSelect(inputArgs, outputResult);
            if (inputArgs.Cancel) { return outputResult; }

            DoSelect(inputArgs, outputResult);

            DoAfterSelect(inputArgs, outputResult);

            return outputResult;
        }

        /// <summary>
        /// 執行 Select 方法前呼叫的方法
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoBeforeSelect(GSelectInputArgs inputArgs, GSelectOutputResult outputResult)
        {
            
        }

        /// <summary>
        /// 執行 Select 方法的實作
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoSelect(GSelectInputArgs inputArgs, GSelectOutputResult outputResult)
        {
            var sTableName = inputArgs.TableName;
            var oTableDefine = this.ProgramDefine.Tables[sTableName];
            if (BaseFunc.IsNull(oTableDefine)) { return; }

            // 因為 Find 與 Move 都會統一進入 Select
            // 所以放在這邊統一做判斷過濾條件是否有包含 SYS_ID 欄位且其值是 *
            // 如滿足條件則需要判斷資料型別，並更改其查詢值
            CheckFilterItemsForDbType(inputArgs.FilterItems);

            // 取得 Select 的欄位集合字串
            var sSelectFields = GetSelectFields(oTableDefine, inputArgs.SelectFields);

            var oDbCommandBuilder = this.CreateDbCommandBuilder();
            var oDbCommand = oDbCommandBuilder.BuildSelectCommand(sTableName, sSelectFields, inputArgs.FilterItems, inputArgs.UserFilter,
                inputArgs.IsOrderBy);
            if (BaseFunc.IsNull(oDbCommand)) { return; }

            var oDataTable = base.DbAccess.ExecuteDataTable(this.DatabaseID, oDbCommand);
            oDataTable.TableName = sTableName;

            if (inputArgs.IsBuildVirtualField)
            {
                // 加入虛擬欄位
                var oVFBuilder = new GVirtualFieldBuilder(oTableDefine, oDataTable);
                oVFBuilder.Execute();
            }
            else
            {
                // 判斷 Select 的欄位是否有虛擬欄位
                var oVFBuilder = new GVirtualFieldBuilder(oTableDefine, oDataTable);
                oVFBuilder.Execute(sSelectFields);
            }

            // 設定資料表中每個欄位的預設值
            BusinessFunc.SetDataColumnDefaultValue(oTableDefine, oDataTable);

            // 設定DataTable主索引鍵
            if (StrFunc.StrIsNotEmpty(oTableDefine.TablePrimaryKey))
                DataFunc.DataTableSetPrimaryKey(oDataTable, oTableDefine.TablePrimaryKey);

            // 資料表同意變更，讓資料表無異動狀態
            oDataTable.AcceptChanges();
            outputResult.EntityTable = new GEntityTable(oDataTable);
        }

        /// <summary>
        /// 建立資料庫命令產生器。
        /// </summary>
        private IDbCommandBuilder CreateDbCommandBuilder()
        {
            return DatabaseFunc.CreateDbCommandBuilder(this.SessionInfo, this.ProgramDefine);
        }

        /// <summary>
        /// 檢查過濾條件的 SYS_ID 欄位的資料型別
        /// </summary>
        /// <param name="filterItems">過濾條件集合。</param>
        /// <remarks>
        /// 如果過濾條件的 SYS_ID 欄位其查詢值是 *
        /// 需要判斷 SYS_ID 的欄位資料型別，再依照型別更改為正確的值。
        /// </remarks>
        private void CheckFilterItemsForDbType(GFilterItemCollection filterItems)
        {
            if (!this.ProgramDefine.MasterTable.Fields.Contains(SysFields.ID)) return;
            var oFieldDefine = this.ProgramDefine.MasterTable.Fields[SysFields.ID];

            foreach (var filterItem in filterItems)
            {
                if (StrFunc.SameText(filterItem.FieldName, SysFields.ID) && StrFunc.SameText(filterItem.FilterValue, "*"))
                {
                    // 資料型別是 Interger 時把查詢值換成 -1
                    if (oFieldDefine.DbType == EFieldDbType.Integer)
                        filterItem.FilterValue = "-1";
                    // 資料型別是 DateTime 時把查詢值換成最小時間 0001/01/01
                    else if (oFieldDefine.DbType == EFieldDbType.DateTime)
                        filterItem.FilterValue = BaseFunc.CDateTime("0001/1/1").ToString("yyyy/MM/dd");
                }
            }
        }

        /// <summary>
        /// 取得 Select 的欄位集合字串。
        /// </summary>
        /// <param name="tableDefine">資料表。</param>
        /// <param name="selectFields"></param>
        private string GetSelectFields(GTableDefine tableDefine, string selectFields)
        {
            if (StrFunc.StrIsEmpty(selectFields)) { return string.Empty; }

            var oSelectFields = StrFunc.StrSplit(selectFields, ",");
            var oFields = new GStringHashSet(selectFields, ",");

            return oFields.ToString(",");
        }

        /// <summary>
        /// 取得欄位集合
        /// </summary>
        /// <returns></returns>
        private GTextItemCollection GetFieldText(IEnumerable<ATableJoin> tableJoins)
        {
            var result = new GTextItemCollection();
            foreach (var field in this.ProgramDefine.MasterFields.Where(x => x.FieldType != EFieldType.VirtualField))
            {
                var tableAlias = field.FieldType == EFieldType.DataField 
                               ? "A" 
                               : tableJoins.FirstOrDefault(x => field.LinkFieldName.Replace("Id", "").SameText(x.TableName))?.AliasName;
                result.AddItem(field.FieldName, tableAlias);
            }
            return result;
        }

        /// <summary>
        /// 取得Join Table 的集合
        /// </summary>
        /// <returns></returns>
        private IEnumerable<ATableJoin> GetTableJoin()
        {
            char NextChar(char letter)
            {
                var nextChar = default(char);
                if (letter == 'z')
                    nextChar = 'a';
                else if (letter == 'Z')
                    nextChar = 'A';
                else
                    nextChar = (char)(((int)letter) + 1);

                return nextChar;
            }


            var result = new List<ATableJoin>();
            var curAliasName = 'A';
            result.Add(new ATableJoin(this.ProgramDefine.MasterTable.TableName, this.ProgramDefine.MasterTable.DbTableName, curAliasName.ToString()));
            foreach (var field in this.ProgramDefine.MasterFields.Where(x => x.FieldType == EFieldType.DataField && !x.LinkProgID.IsEmpty()))
            {
                var linkProgDefine = CacheFunc.GetProgramDefine("HUM", field.LinkProgID);
                curAliasName = NextChar(curAliasName);
                result.Add(new ATableJoin(linkProgDefine.MasterTable.TableName, linkProgDefine.MasterTable.DbTableName, curAliasName.ToString()));
            }
            return result;
        }

        /// <summary>
        /// 執行 Select 方法後呼叫的方法
        /// </summary>
        /// <param name="inputArgs"></param>
        /// <param name="outputResult"></param>
        protected virtual void DoAfterSelect(GSelectInputArgs inputArgs, GSelectOutputResult outputResult)
        {
            
        }
    }
}
