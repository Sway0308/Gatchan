using ME.Base;
using ME.Define;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// Entity 資料表(指定型別)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GEntityTable<T> : GEntityTable where T : GEntityRow
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="entityTable"></param>
        public GEntityTable(GEntityTable entityTable, GInstanceType instanceType) : base()
        {
            this.TableName = entityTable.TableName;
            this.OriginalEntityTable = entityTable;
            ConvertToGEntityRow(instanceType);
        }

        /// <summary>
        /// Entity 資料列集合
        /// </summary>
        public Dictionary<T, GEntityRow> EntityRows { get; } = new Dictionary<T, GEntityRow>();

        /// <summary>
        /// 原始 Entity 資料表
        /// </summary>
        public GEntityTable OriginalEntityTable { get; }

        /// <summary>
        /// 轉換為Entity資料列
        /// </summary>
        private void ConvertToGEntityRow(GInstanceType instanceType)
        {
            foreach (var entity in OriginalEntityTable.Rows)
            {
                var realEntity = (T)DefineFunc.CreateEntityRow(instanceType);
                this.EntityRows.Add(entity.ToRealEntity(realEntity), entity);
            }
        }
    }

    /// <summary>
    /// Entity 資料表
    /// </summary>
    public class GEntityTable : GKeyCollectionItem
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public GEntityTable()
        { }

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="tableName">資料表名稱</param>
        public GEntityTable(string tableName) : base()
        {
            this.TableName = tableName;
        }

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="table">資料表</param>
        public GEntityTable(DataTable table) : base()
        {
            this.TableName = table.TableName;
            ConvertTabletoEntity(table);
        }

        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TableName { get => base.Key; set => base.Key = value; }

        /// <summary>
        /// 資料列集合
        /// </summary>
        public List<GEntityRow> Rows { get; } = new List<GEntityRow>();

        /// <summary>
        /// 將資料表轉為實體資料列集合
        /// </summary>
        /// <param name="table"></param>
        public void ConvertTabletoEntity(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                var entity = new GEntityRow(table.Columns);
                foreach (var fieldName in entity.FieldNames)
                    entity.SetValue(fieldName, row[fieldName]);
                this.Rows.Add(entity);
            }
        }

        /// <summary>
        /// 物件描述
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Name：{0}, Count：{1}", this.TableName, this.Rows.Count());
        }
    }
}
