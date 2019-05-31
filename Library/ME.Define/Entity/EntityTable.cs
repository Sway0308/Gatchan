using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// Entity 資料表
    /// </summary>
    public class EntityTable
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="table"></param>
        public EntityTable(DataTable table)
        {
            this.TableName = table.TableName;
            var colNames = table.Columns.Cast<DataColumn>().Select(x => x.ColumnName);
            foreach (DataRow row in table.Rows)
            {
                //this.Rows.Add()
                foreach (var colName in colNames)
                {

                }
            }
        }

        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TableName { get; } = string.Empty;

        /// <summary>
        /// 資料列集合
        /// </summary>
        public List<IEntityRow> Rows { get; } = new List<IEntityRow>();
    }
}
