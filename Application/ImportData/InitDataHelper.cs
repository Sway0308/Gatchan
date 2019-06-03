using ME.Base;
using ME.Define;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ME.Cahce;
using ME.Business;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.ComponentModel;

namespace ImportData
{
    /// <summary>
    /// 檔案初始化輔助器
    /// </summary>
    [Description]
    public class InitDataHelper
    {
        private string CurrentPath { get; } = @"C:\Users\SCSRD\Downloads\TestCode\BaseBL";
        /// <summary>
        /// 檔案路徑
        /// </summary>
        private string AppDataPath => $@"{this.CurrentPath}\APP_Data";
        /// <summary>
        /// 設定檔檔案路徑
        /// </summary>
        private string SettingDataPath => $@"{this.AppDataPath}\Common\HUM";
        /// <summary>
        /// 程式定義路徑
        /// </summary>
        private string ProgDefineDataPath => $@"{SettingDataPath}\ProgramDefine";
        /// <summary>
        /// 資料表定義路徑
        /// </summary>
        private string DbDefineDataPath => $@"{SettingDataPath}\DbTableDefine";

        private Guid SessionGuid => Guid.NewGuid();

        /// <summary>
        /// 檔案初始化
        /// </summary>
        public void InitData()
        {;
            InitDbSetting();
            InitProgSetting();
            InitProgDefine();
        }

        /// <summary>
        /// 初始化程式定義
        /// </summary>
        private void InitProgDefine()
        {
            var depart = CreateProgDefines("Depart", "部門");
            var duty = CreateProgDefines("Duty", "職缺");
            var employee = CreateProgDefines("Employee", "員工");
            AddLinkReturnField(employee.MasterFields, depart);
            AddLinkReturnField(employee.MasterFields, duty);
            ProgDefineToJson(depart);
            ProgDefineToJson(duty);
            ProgDefineToJson(employee);
        }

        /// <summary>
        /// 初始化程式設定
        /// </summary>
        private void InitProgSetting()
        {
            var progSetting = new GProgramSetting();
            progSetting.Items.AddItem(new GProgramItem { ProgID = "Depart", DisplayName = "部門" });
            progSetting.Items.AddItem(new GProgramItem { ProgID = "Duty", DisplayName = "職缺" });
            progSetting.Items.AddItem(new GProgramItem { ProgID = "Employee", DisplayName = "員工", BusinessInstanceType = { AssemblyFile = "TUBE.FD.dll", TypeName = "TUBE.FD.AEmployeeBusinessLogic" } });
            ProgSettingToJson(progSetting);
        }

        /// <summary>
        /// 初始化資料庫清單設定
        /// </summary>
        private void InitDbSetting()
        {
            var dbSetting = new GDatabaseSettings();
            dbSetting.Items.Add(new GDatabaseItem { ID = "001", DisplayName = "Demo", DbServer = "localhost", DbName = "SkyDb", LoginID = "sa", Password = "guest" });
            DbSettingToJson(dbSetting);
        }

        /// <summary>
        /// 資料庫清單設定轉Json
        /// </summary>
        /// <param name="dbSetting"></param>
        private void DbSettingToJson(GDatabaseSettings dbSetting)
        {
            var json = BaseFunc.ObjectToJson(dbSetting);
            var fileName = $@"DatabaseSettings.json";
            FileFunc.FileWriteAllText(this.AppDataPath, fileName, json);
        }

        /// <summary>
        /// 產生程式定義
        /// </summary>
        /// <param name="progID"></param>
        /// <param name="displayName"></param>
        /// <returns></returns>
        private GProgramDefine CreateProgDefines(string progID, string displayName)
        {
            var progDefine = new GProgramDefine { ProgID = progID, DisplayName = displayName };
            var tableDefine = new GTableDefine { TableName = progID, DisplayName = displayName, DbTableName = progID, PrimaryKey = $"{progID}ID" };
            tableDefine.Fields.AddItem(new GFieldDefine { FieldName = $"{progID}ID", DisplayName = $"{displayName}編號", MaxLength = 10, DbType = EFieldDbType.GUID });
            tableDefine.Fields.AddItem(new GFieldDefine { FieldName = $"{progID}Code", DisplayName = $"{displayName}代碼", MaxLength = 10 });
            tableDefine.Fields.AddItem(new GFieldDefine { FieldName = $"{progID}Name", DisplayName = $"{displayName}名稱", MaxLength = 10 });
            progDefine.Tables.AddItem(tableDefine);
            return progDefine;
        }

        /// <summary>
        /// 加入關連欄位
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="linkProgID"></param>
        /// <param name="linkDisplayName"></param>
        private void AddLinkReturnField(GFieldDefineCollection fields, GProgramDefine linkProgDefine)
        {
            var linkProgID = linkProgDefine.ProgID;
            var linkDisplayName = linkProgDefine.DisplayName;

            var linkField = new GFieldDefine { FieldName = $"{linkProgID}ID", DisplayName = $"{linkDisplayName}編號", MaxLength = 10, LinkProgID = linkProgID, DbType = EFieldDbType.GUID };
            linkField.LinkReturnFields.AddItem(new GLinkReturnField { SourceField = $"{linkProgID}ID", DestField = $"{linkProgID}ID" });
            linkField.LinkReturnFields.AddItem(new GLinkReturnField { SourceField = $"{linkProgID}Code", DestField = $"TMP_{linkProgID}Code" });
            linkField.LinkReturnFields.AddItem(new GLinkReturnField { SourceField = $"{linkProgID}Name", DestField = $"TMP_{linkProgID}Name" });
            fields.AddItem(linkField);
            fields.AddItem(new GFieldDefine { FieldName = $"TMP_{linkProgID}Code", DisplayName = $"{linkDisplayName}代碼", FieldType = EFieldType.LinkField, LinkFieldName = $"{linkProgID}ID" });
            fields.AddItem(new GFieldDefine { FieldName = $"TMP_{linkProgID}Name", DisplayName = $"{linkDisplayName}名稱", FieldType = EFieldType.LinkField, LinkFieldName = $"{linkProgID}ID" });
        }

        /// <summary>
        /// 程式定義轉XML
        /// </summary>
        /// <param name="programDefine"></param>
        public void ProgDefineToJson(GProgramDefine programDefine)
        {
            var json = BaseFunc.ObjectToJson(programDefine);
            var fileName = $@"{programDefine.ProgID}.ProgramDefine.json";
            FileFunc.FileWriteAllText(this.ProgDefineDataPath, fileName, json);
            ProgDefineToTableDefineToJson(programDefine);
        }

        /// <summary>
        /// 程式定義轉資料表定義
        /// </summary>
        /// <param name="programDefine"></param>
        private void ProgDefineToTableDefineToJson(GProgramDefine programDefine)
        {
            var dbDefines = DefineFunc.ProgDefineToDbTableDefine(programDefine);
            foreach (var d in dbDefines)
            {
                var dbJson = BaseFunc.ObjectToJson(d);
                var dbPath = $@"{d.TableName}.DbTableDefine.json";
                FileFunc.FileWriteAllText(this.DbDefineDataPath, dbPath, dbJson);
            }
        }

        /// <summary>
        /// 程式定義轉XML
        /// </summary>
        /// <param name="programSetting"></param>
        private void ProgSettingToJson(GProgramSetting programSetting)
        {
            var json = BaseFunc.ObjectToJson(programSetting);
            var fileName = $@"ProgramSetting.json";
            FileFunc.FileWriteAllText(this.SettingDataPath, fileName, json);
        }

        /// <summary>
        /// 根據路徑取得定義檔案
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        private IEnumerable<T> GetDefines<T>(string path) where T : GKeyCollectionItem
        {
            var files = from f in Directory.EnumerateFiles(path, "*.json", SearchOption.TopDirectoryOnly)
                        select new { Text = FileFunc.FileReadAllText(f) };
            foreach (var file in files)
            {
                var define = BaseFunc.JsonToObject<T>(file.Text);
                if (!define.Key.IsEmpty())
                    yield return define;
            }
        }

        /// <summary>
        /// 根據路徑取得定義檔案
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        private T GetDefine<T>(string path)
        {
            var files = from f in Directory.EnumerateFiles(path, "*.json", SearchOption.TopDirectoryOnly)
                        select new { Text = FileFunc.FileReadAllText(f) };
            return BaseFunc.JsonToObject<T>(files.FirstOrDefault().Text);
        }

        /// <summary>
        /// 建立資料表
        /// </summary>
        public void CreateDbTable()
        {
            //var progSettings = GetDefine<AProgramSetting>(this.SettingDataPath);
            //var progDefines = GetDefines<AProgramDefine>(this.ProgDefineDataPath);
            var dbDefines = GetDefines<GDbTableDefine>(this.DbDefineDataPath);
            var dbSetting = CacheFunc.GetDatabaseSettings();
            var helper = new UpgradeTableHelper(dbSetting);
            foreach (var define in dbDefines)
            {
                helper.UpgradeTable(define);
            }
        }

        /// <summary>
        /// 新增資料
        /// </summary>
        public void AddData()
        {
            var files = from f in Directory.EnumerateFiles($@"{this.CurrentPath}\DemoData\ImportData", "*.json", SearchOption.TopDirectoryOnly)
                        select new { FileName = FileFunc.GetFileName(f).Replace(".json", ""), Text = FileFunc.FileReadAllText(f) };
            foreach (var file in files)
            {
                var dt = JsonConvert.DeserializeObject<DataTable>(file.Text);
                dt.TableName = file.FileName;
                var dataSet = DataFunc.CreateDataSet(file.FileName);
                
                dataSet.Tables.Add(dt);
                var bl = BusinessFunc.CreateBusinessLogic(this.SessionGuid, file.FileName);
                var result = bl.Save(new GSaveInputArgs { DataSet = dataSet, SaveMode = ESaveMode.Add });
            }
        }

        /// <summary>
        /// 修改資料
        /// </summary>
        public void EditData()
        {
            var files = from f in Directory.EnumerateFiles($@"{this.CurrentPath}\DemoData\FindData", "*.json", SearchOption.TopDirectoryOnly)
                        select new { ProgID = FileFunc.GetFileName(f).Replace(".json", ""), Text = FileFunc.FileReadAllText(f) };
            foreach (var file in files)
            {
                var table = JsonConvert.DeserializeObject<DataTable>(file.Text);
                foreach (DataRow row in table.Rows)
                {
                    row[$"{file.ProgID}Code"] = row.ValueAsString($"{file.ProgID}Code") + "_2";
                }

                table.TableName = file.ProgID;
                var dataSet = DataFunc.CreateDataSet(file.ProgID);

                dataSet.Tables.Add(table);
                var bl = BusinessFunc.CreateBusinessLogic(this.SessionGuid, file.ProgID);
                var result = bl.Save(new GSaveInputArgs { DataSet = dataSet, SaveMode = ESaveMode.Edit });
            }
        }

        /// <summary>
        /// 刪除資料
        /// </summary>
        public void DeleteData()
        {
            var files = from f in Directory.EnumerateFiles($@"{CurrentPath}\DemoData\FindData", "*.json", SearchOption.TopDirectoryOnly)
                        select new { ProgID = FileFunc.GetFileName(f).Replace(".json", ""), Text = FileFunc.FileReadAllText(f) };
            foreach (var file in files)
            {
                var jsonArray = JArray.Parse(file.Text);
                var bl = BusinessFunc.CreateBusinessLogic(this.SessionGuid, file.ProgID);

                foreach (var json in jsonArray.Children<JObject>())
                {
                    var result = bl.Delete(new GDeleteInputArgs { FormID = json.TokenAsString($"{file.ProgID}ID") });
                }                
            }
        }

        /// <summary>
        /// 查詢單一資料
        /// </summary>
        public void FindSingleData()
        {
            var bl = BusinessFunc.CreateBusinessLogic(this.SessionGuid, "Employee");
            var result = bl.Find(new GFindInputArgs());
        }

        /// <summary>
        /// 清單查詢
        /// </summary>
        public void FindData()
        {
            var bl = BusinessFunc.CreateBusinessLogic(this.SessionGuid, "Employee");
            var result = bl.Find(new GFindInputArgs());
            var table = result.EntityTable;
            var json = JsonConvert.SerializeObject(table, Formatting.Indented);
            FileFunc.FileWriteAllText($@"{CurrentPath}\DemoData\FindData", "Employee.json", json);
        }
    }
}
