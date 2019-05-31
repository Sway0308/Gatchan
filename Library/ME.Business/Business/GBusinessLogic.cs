using ME.Base;
using ME.Cahce;
using ME.Define;
using System;
using System.Collections.Generic;
using System.Data;
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
        public GBusinessLogic(string progID) : base(progID)
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
            var selectArgs = new GSelectInputArgs { Parameters = inputArgs.Parameters };
            var selectResult = Select(selectArgs);
            outputResult.EntitySet = selectResult.EntitySet;
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
            var selectArgs = new GSelectInputArgs { Parameters = { new GParameter($"{this.ProgID}ID", inputArgs.FormID) } };
            var selectResult = Select(selectArgs);
            outputResult.EntitySet = selectResult.EntitySet;
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
            var sql = new StringBuilder();
            sql.AppendLine("Select");
            var tableJoins = GetTableJoin();
            var fieldTexts = GetFieldText(tableJoins);
            var lastField = fieldTexts.Last();
            foreach (var field in fieldTexts)
            {
                var fieldText = $"{field.Value}.{field.Name}";
                var fieldDefine = this.ProgramDefine.MasterFields[field.Name];
                if (fieldDefine.FieldType == EFieldType.LinkField)
                {
                    var activeLinkFieldDefine = this.ProgramDefine.MasterFields.FindActiveLinkFieldDefine(fieldDefine.LinkFieldName);
                    if (activeLinkFieldDefine != null)
                    {
                        var linkReturnField = activeLinkFieldDefine.LinkReturnFields.FindByDestField(fieldDefine.FieldName);
                        if (linkReturnField != null)
                            fieldText = $"{field.Value}.{linkReturnField.SourceField} as {linkReturnField.DestField}";
                    }
                }

                sql.AppendLine($"{fieldText}" + (field == lastField ? "" : ","));
            }

            var firstTable = tableJoins.First();
            foreach (var tableJoin in tableJoins)
            {
                var tableName = tableJoin.TableName;
                var dbTableName = tableJoin.DbTableName;
                var alias = tableJoin.AliasName;
                var isJoin = tableJoin != firstTable;
                sql.AppendLine((!isJoin ? "From " : "Left Join ") + dbTableName + $" {alias}" + (!isJoin ? "" : $" On A.{tableName}ID = {alias}.{tableName}ID"));
            }
            sql.AppendLine("Where 1 = 1");
            foreach (var para in inputArgs.Parameters)
            {
                var fieldName = para.Name;
                var field = this.ProgramDefine.MasterFields[fieldName];
                if (field == null)
                    continue;
                var fieldText = fieldTexts.FirstOrDefault(x => x.Name.SameText(fieldName));
                if (fieldText == null)
                    continue;
                sql.AppendLine($"And {fieldText.Value}.{fieldText.Name} = {para.Value.ToString().SQLStr()}");
            }

            var table = this.DbAccess.ExecuteDataTable(this.DatabaseID, sql.ToString());
            table.TableName = this.ProgID;
            var dataSet = DataFunc.CreateDataSet(this.ProgID);
            dataSet.Tables.Add(table);
            outputResult.EntitySet = new GEntitySet(dataSet);
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
