using ME.Base;
using ME.Define;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Database
{
    /// <summary>
    /// 資料表關連資訊提供者。
    /// </summary>
    public class GTableJoinProvider
    {
        /// <summary>
        /// 資料表關連集合。
        /// </summary>
        public GTableJoinCollection TableJoins { get; } = new GTableJoinCollection();

        /// <summary>
        /// 關連欄位對應集合。
        /// </summary>
        public GLinkFieldMappingCollection Mappings { get; } = new GLinkFieldMappingCollection();

        /// <summary>
        /// 程式定義
        /// </summary>
        private GProgramDefine ProgramDefine { get; set; }

        /// <summary>
        /// 資料表名稱
        /// </summary>
        private string TableName { get; set; }

        /// <summary>
        /// 資料表定義
        /// </summary>
        private GTableDefine TableDefine => this.ProgramDefine.Tables[this.TableName];

        /// <summary>
        /// 建置資料表關連資訊。
        /// </summary>
        /// <param name="programDefine">程式定義。</param>
        /// <param name="tableName">資料表名稱。</param>
        /// <param name="selectFields">取回欄位集合字串。</param>
        /// <param name="filterItems">過濾條件項目集合。</param>
        /// <param name="sortFields">排序欄位集合。</param>
        public void Execute(GProgramDefine programDefine, string tableName, string selectFields, GFilterItemCollection filterItems, GSortFieldCollection sortFields)
        {
            this.ProgramDefine = programDefine;
            this.TableName = tableName;
            var oBuilder = new GTableJoinBuilder(programDefine, tableName, selectFields, filterItems, sortFields);
            oBuilder.Execute(this);
        }

        /// <summary>
        /// 取得 SELECT 欄位。
        /// </summary>
        /// <param name="helper">資料庫命令輔助類別。</param>
        /// <param name="fieldDefine">欄位定義。</param>
        public string GetSelectField(IDbCommandHelper helper, GFieldDefine fieldDefine)
        {
            var oMapping = this.Mappings[fieldDefine.FieldName];

            if (BaseFunc.IsNull(oMapping))
            {
                if (StrFunc.SameText(fieldDefine.FieldName, fieldDefine.DbFieldName))
                    return StrFunc.StrFormat("{0}.{1}", "A", helper.GetFieldName(fieldDefine.FieldName));
                else
                    return StrFunc.StrFormat("{0}.{1} As {2}", "A", helper.GetFieldName(fieldDefine.DbFieldName), fieldDefine.FieldName);
            }
            else
            {
                return StrFunc.StrFormat("{0}.{1} As {2}", oMapping.TableAlias, helper.GetFieldName(oMapping.SourceFieldName), fieldDefine.FieldName);
            }
        }

        /// <summary>
        /// 取得選取明細欄位。
        /// </summary>
        /// <param name="helper">資料庫命令輔助類別。</param>
        /// <param name="fieldDefine">欄位定義。</param>
        public string GetDetailSelectField(IDbCommandHelper helper, GFieldDefine fieldDefine)
        {
            GLinkFieldMapping oMapping;
            string sTableAlias;
            string sFieldName;

            sTableAlias = "DA";
            sFieldName = StrFunc.StrFormat("{0}.{1}", this.TableName, fieldDefine.FieldName);
            oMapping = this.Mappings[sFieldName];

            if (BaseFunc.IsNull(oMapping))
            {
                return StrFunc.StrFormat("{0}.{1} As {2}",
                  sTableAlias, helper.GetFieldName(fieldDefine.DbFieldName), helper.GetFieldName(sFieldName));
            }
            else
            {
                return StrFunc.StrFormat("{0}.{1} As {2}",
                    oMapping.TableAlias, helper.GetFieldName(oMapping.SourceFieldName), helper.GetFieldName(sFieldName));
            }
        }

        /// <summary>
        /// 取得包含資料表別名的欄位名稱。
        /// </summary>
        /// <param name="helper">資料庫命令輔助類別。</param>
        /// <param name="fieldDefine">欄位定義。</param>
        public string GetDbFieldName(IDbCommandHelper helper, GFieldDefine fieldDefine)
        {
            GLinkFieldMapping oMapping;

            oMapping = this.Mappings[fieldDefine.FieldName];

            if (BaseFunc.IsNull(oMapping))
                return StrFunc.StrFormat("{0}.{1}", "A", helper.GetFieldName(fieldDefine.DbFieldName));
            else
                return StrFunc.StrFormat("{0}.{1}", oMapping.TableAlias, helper.GetFieldName(oMapping.SourceFieldName));
        }

        /// <summary>
        /// 取得包含資料表別名的明細欄位名稱。
        /// </summary>
        /// <param name="helper">資料庫命令輔助類別。</param>
        /// <param name="fieldDefine">欄位定義。</param>
        public string GetDetailDbFieldName(IDbCommandHelper helper, GFieldDefine fieldDefine)
        {
            GLinkFieldMapping oMapping;
            string sFieldName;

            sFieldName = StrFunc.StrFormat("{0}.{1}", this.TableName, fieldDefine.FieldName);
            oMapping = this.Mappings[sFieldName];

            if (BaseFunc.IsNull(oMapping))
                return StrFunc.StrFormat("{0}.{1}", "DA", helper.GetFieldName(fieldDefine.DbFieldName));
            else
                return StrFunc.StrFormat("{0}.{1}", oMapping.TableAlias, helper.GetFieldName(oMapping.SourceFieldName));
        }
    }
}
