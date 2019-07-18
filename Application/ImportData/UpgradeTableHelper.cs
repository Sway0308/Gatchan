using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ME.Database;
using ME.Define;
using ME.Base;

namespace ImportData
{
    /// <summary>
    /// 資料表升級輔助器
    /// </summary>
    public class UpgradeTableHelper
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="dbSetting"></param>
        public UpgradeTableHelper(GDatabaseSettings dbSetting)
        {
            this.DbAccess = new GDbAccess(dbSetting);
        }

        /// <summary>
        /// 資料庫存取物件
        /// </summary>
        private GDbAccess DbAccess { get; }

        /// <summary>
        /// 資料庫代碼
        /// </summary>
        private string DatabaseID { get; } = "001";

        /// <summary>
        /// 升級資料表
        /// </summary>
        /// <param name="dbDefine"></param>
        public void UpgradeTable(GDbTableDefine dbDefine)
        {
            if (TableExists(dbDefine.TableName))
                return;
            var sql = new StringBuilder();
            sql.AppendLine("BEGIN TRANSACTION");
            sql.AppendLine($"CREATE TABLE dbo.{dbDefine.TableName}");
            sql.AppendLine("(");
            foreach (GDbFieldDefine fieldDefine in dbDefine.Fields)
            {
                var text = $@"[{fieldDefine.FieldName}] {ToDbType(fieldDefine.DbType, fieldDefine.MaxLength)} {AllowNull(fieldDefine.AllowNull)},";
                sql.AppendLine(text);
            }           
            sql.AppendLine(")");
            sql.AppendLine($"ALTER TABLE dbo.{dbDefine.TableName} SET (LOCK_ESCALATION = TABLE)");
            sql.AppendLine("COMMIT");

            this.DbAccess.ExecuteNonQuery(this.DatabaseID, sql.ToString());
        }

        private string ToDbType(EFieldDbType dbType, int maxLength)
        {
            switch (dbType)
            {
                case EFieldDbType.Boolean:
                    return "[bit]";
                case EFieldDbType.GUID:
                    return "[uniqueidentifier]";
                case EFieldDbType.Currency:
                    return "[money]";
                case EFieldDbType.Double:
                    return "[float]";
                case EFieldDbType.DateTime:
                    return "[datetime]";
                case EFieldDbType.Integer:
                    return "[int]";
                case EFieldDbType.String:
                    return $"[nvarchar]({maxLength})";
                case EFieldDbType.Text:
                case EFieldDbType.Binary:
                default:
                    return "[nvarchar](MAX)";
            }
        }

        private string AllowNull(bool allowNull)
        {
            return allowNull ? "NULL" : "NOT NULL";
        }

        /// <summary>
        /// 資料表是否存在
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private bool TableExists(string tableName)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select A.name as TableName, B.name as ColumnName");
            sql.AppendLine("From sys.tables A");
            sql.AppendLine("Inner Join sys.columns B On A.object_id = B.object_id");
            sql.AppendLine($"Where A.name = {tableName.SQLStr()}");
            var result = this.DbAccess.ExecuteDataTable(this.DatabaseID, sql.ToString());
            return !DataFunc.IsEmpty(result);
        }
    }
}
