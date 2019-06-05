using ME.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// Entity 資料集(指定型別)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GEntitySet<T> : GEntitySet where T : GEntityRow
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="entitySet"></param>
        public GEntitySet(GEntitySet entitySet, GInstanceType instanceType) : base()
        {
            this.DataSetName = entitySet.DataSetName;
            this.OriginalEntitySet = entitySet;
        }

        /// <summary>
        /// 原始Entity資料集
        /// </summary>
        private GEntitySet OriginalEntitySet { get; }

        /// <summary>
        /// 資料表
        /// </summary>
        public Dictionary<GEntityTable<T>, GEntityTable> EntityTables { get; } = new Dictionary<GEntityTable<T>, GEntityTable>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tables"></param>
        private void ConvertGTables(GInstanceType instanceType)
        {
            foreach (GEntityTable table in this.OriginalEntitySet.Tables)
                this.EntityTables.Add(new GEntityTable<T>(table, instanceType), table);
        }
    }

    /// <summary>
    /// Entity 資料集
    /// </summary>
    public class GEntitySet
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public GEntitySet()
        {
        }

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="dataSetName">資料集名稱</param>
        public GEntitySet(string dataSetName) : base()
        {
            this.DataSetName = dataSetName;
        }

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="dataSet">資料集</param>
        public GEntitySet(DataSet dataSet)
        {
            this.DataSetName = dataSet.DataSetName;
            foreach (DataTable table in dataSet.Tables)
            {
                this.Tables.Add(new GEntityTable(table));
            }
        }

        /// <summary>
        /// 資料集名稱
        /// </summary>
        public string DataSetName { get; set; }
        /// <summary>
        /// 資料表集合
        /// </summary>
        public GEntityTableCollection Tables { get; } = new GEntityTableCollection();

        /// <summary>
        /// 物件描述
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Name：{0}, Count：{1}", this.DataSetName, this.Tables.Count);
        }
    }
}
