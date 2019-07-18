using ME.Base;
using ME.Business;
using ME.Cahce;
using ME.Define;
using ME.Setting;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Linq;

namespace ImportData
{
    /// <summary>
    /// 檔案初始化輔助器
    /// </summary>
    public class InitDataHelper
    {
        private string CurrentPath => Directory.GetParent(BaseInfo.AppDataPath).FullName;
        private Guid SessionGuid => Guid.NewGuid();

        /// <summary>
        /// 定義儲存輔助器
        /// </summary>
        private GSaveDefineHelper SaveDefineHelper { get; } = new GSaveDefineHelper();

        /// <summary>
        /// 檔案初始化
        /// </summary>
        public void InitData()
        {
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
            var progSetting = new GProgramSetting("HUM") { DisplayName = "人資管理" };
            progSetting.Modules.Add(new GProgramModule("Emp"));
            progSetting.Modules["Emp"].Items.Add(new GProgramItem("Depart") { DisplayName = "部門" });
            progSetting.Modules["Emp"].Items.Add(new GProgramItem("Duty") { DisplayName = "職缺" });
            progSetting.Modules["Emp"].Items.Add(new GProgramItem("Employee") { DisplayName = "員工" });
            this.SaveDefineHelper.SaveDefine(progSetting);
        }

        /// <summary>
        /// 初始化資料庫清單設定
        /// </summary>
        private void InitDbSetting()
        {
            var dbSetting = new GDatabaseSettings();
            dbSetting.Items.Add(new GDatabaseItem("001")
            {
                DisplayName = "Demo",
                DbServer = "localhost",
                DbName = "SkyDb",
                LoginID = "sa",
                Password = "guest"
            });
            this.SaveDefineHelper.SaveDefine(dbSetting);
        }

        /// <summary>
        /// 產生程式定義
        /// </summary>
        /// <param name="progID"></param>
        /// <param name="displayName"></param>
        /// <returns></returns>
        private GProgramDefine CreateProgDefines(string progID, string displayName)
        {
            var progDefine = new GProgramDefine { SystemID = "HUM", ProgID = progID, DisplayName = displayName };
            var tableDefine = new GTableDefine { TableName = progID, DisplayName = displayName, DbTableName = progID, PrimaryKey = $"{progID}ID" };
            tableDefine.Fields.Add(new GFieldDefine { FieldName = SysFields.CompanyID, DisplayName = $"公司編號", MaxLength = 10 });
            tableDefine.Fields.Add(new GFieldDefine { FieldName = SysFields.ID, DisplayName = $"{displayName}編號", MaxLength = 10 });
            tableDefine.Fields.Add(new GFieldDefine { FieldName = SysFields.ViewID, DisplayName = $"{displayName}代碼", MaxLength = 10 });
            tableDefine.Fields.Add(new GFieldDefine { FieldName = SysFields.Name, DisplayName = $"{displayName}名稱", MaxLength = 10 });
            progDefine.Tables.Add(tableDefine);
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

            var linkField = new GFieldDefine { FieldName = $"{linkProgID}ID", DisplayName = $"{linkDisplayName}編號", MaxLength = 10, LinkProgID = linkProgID };
            linkField.LinkReturnFields.Add(new GLinkReturnField { SourceField = SysFields.ID, DestField = $"{linkProgID}ID" });
            linkField.LinkReturnFields.Add(new GLinkReturnField { SourceField = SysFields.ViewID, DestField = $"TMP_{linkProgID}ID" });
            linkField.LinkReturnFields.Add(new GLinkReturnField { SourceField = SysFields.Name, DestField = $"TMP_{linkProgID}Name" });
            fields.Add(linkField);
            fields.Add(new GFieldDefine { FieldName = $"TMP_{linkProgID}ID", DisplayName = $"{linkDisplayName}代碼", FieldType = EFieldType.LinkField, LinkFieldName = $"{linkProgID}ID" });
            fields.Add(new GFieldDefine { FieldName = $"TMP_{linkProgID}Name", DisplayName = $"{linkDisplayName}名稱", FieldType = EFieldType.LinkField, LinkFieldName = $"{linkProgID}ID" });
        }

        /// <summary>
        /// 程式定義轉XML
        /// </summary>
        /// <param name="programDefine"></param>
        public void ProgDefineToJson(GProgramDefine programDefine)
        {
            this.SaveDefineHelper.SaveDefine(programDefine);

            var dbDefines = DefineFunc.ProgDefineToDbTableDefine(programDefine);
            foreach (var d in dbDefines)
            {
                this.SaveDefineHelper.SaveDefine(d);
            }
        }

        /// <summary>
        /// 建立資料表
        /// </summary>
        public void CreateDbTable()
        {
            var dbDefines = CacheFunc.GetDbTableDefines();
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
                var table = new GEntityTable(dt);
                var dataSet = new GEntitySet(file.FileName);
                
                dataSet.Tables.Add(table);
                var bl = BusinessFunc.CreateBusinessLogic(this.SessionGuid, file.FileName);
                var result = bl.Save(new GSaveInputArgs { EntitySet = dataSet, SaveMode = ESaveMode.Add });
            }
        }

        /// <summary>
        /// 修改資料
        /// </summary>
        public void EditData()
        {
            var bl = BusinessFunc.CreateBusinessLogic(this.SessionGuid, "Employee");
            var result = bl.Find(new GFindInputArgs());
            var table = result.EntityTable;
            foreach (GEntityRow row in result.EntityTable.Rows)
            {
                row.SetValue(SysFields.ViewID, row.ValueAsString(SysFields.ViewID) + "_2");
            }
            var dataSet = new GEntitySet(table.TableName);
            dataSet.Tables.Add(table);
            var saveResult = bl.Save(new GSaveInputArgs { EntitySet = dataSet, SaveMode = ESaveMode.Edit });
        }

        /// <summary>
        /// 刪除資料
        /// </summary>
        public void DeleteData()
        {
            var bl = BusinessFunc.CreateBusinessLogic(this.SessionGuid, "Employee");
            var result = bl.Find(new GFindInputArgs());
            var table = result.EntityTable;
            foreach (GEntityRow row in result.EntityTable.Rows)
            {
                bl.Delete(new GDeleteInputArgs { FormID = row.ValueAsString(SysFields.ID) });
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
