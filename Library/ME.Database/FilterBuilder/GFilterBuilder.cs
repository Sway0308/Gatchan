using ME.Base;
using ME.Define;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Database
{
    public class GFilterBuilder : IFilterBuilder
    {
        #region 建構函式

        /// <summary>
        /// 建構函式。
        /// </summary>
        /// <param name="filterInputArgs">過濾條件字串輸入參數。</param>
        public GFilterBuilder(GFilterInputArgs filterInputArgs)
        {
            Args = filterInputArgs;
        }

        #endregion

        /// <summary>
        /// 過濾條件字串輸入參數。
        /// </summary>
        private GFilterInputArgs Args { get; }

        /// <summary>
        /// 資料庫命令輔助類別介面。
        /// </summary>
        private IDbCommandHelper DbCommandHelper
        {
            get { return this.Args.DbCommandHelper; }
        }

        /// <summary>
        /// 連線資訊。
        /// </summary>
        public GSessionInfo SessionInfo
        {
            get { return this.Args.SessionInfo; }
        }

        /// <summary>
        /// 取得過濾條件。
        /// </summary>
        /// <param name="join">傳出過濾條件需要額外加入的 JOIN 語法。</param>
        public string GetFilter(out string join)
        {
            GFilterItemCollection oFilterItems;
            GFilterItemsParser oParser;
            StringBuilder oBuilder;
            GDictionary<GFilterItemCollection> oList;
            string sFilter;

            // 解析過濾條件中的系統變數
            oParser = new GFilterItemsParser(this.SessionInfo, this.Args.FilterItems);
            oFilterItems = oParser.ParseVariable();

            join = string.Empty;
            oBuilder = new StringBuilder();
            //取得群組過濾條件集合
            oList = GetGroupFilterItems(oFilterItems);
            foreach (GFilterItemCollection filterItems in oList.Values)
            {
                sFilter = GetFilter(filterItems);
                if (StrFunc.StrIsNotEmpty(sFilter))
                {
                    if (oBuilder.Length > 0)
                        oBuilder.AppendFormat(" {0} ", filterItems[0].CombineOperator);
                    oBuilder.Append(sFilter);
                }
            }

            return oBuilder.ToString();
        }

        /// <summary>
        /// 取得群組過濾條件。
        /// </summary>
        /// <param name="sourceFilterItems">過濾條件項目集合。</param>
        public string GetGroupFileter(GFilterItemCollection sourceFilterItems)
        {
            StringBuilder oBuilder;
            GDictionary<GFilterItemCollection> oList;
            string sFilter;

            oBuilder = new StringBuilder();

            //取得群組過濾條件集合
            oList = GetGroupFilterItems(sourceFilterItems);
            foreach (GFilterItemCollection filterItems in oList.Values)
            {
                sFilter = GetFilter(filterItems);
                if (StrFunc.StrIsNotEmpty(sFilter))
                {
                    if (oBuilder.Length > 0)
                        oBuilder.AppendFormat(" {0} ", filterItems[0].CombineOperator);
                    oBuilder.Append(sFilter);
                }
            }

            return oBuilder.ToString();
        }

        /// <summary>
        /// 取得過濾條件。
        /// </summary>
        /// <param name="filterItems">過濾條件項目集合。</param>
        private string GetFilter(GFilterItemCollection filterItems)
        {
            StringBuilder oBuilder;
            string sFilter;

            oBuilder = new StringBuilder();
            foreach (GFilterItem item in filterItems)
            {
                sFilter = ProcessFilterItem(item);

                if (StrFunc.StrIsNotEmpty(sFilter))
                {
                    if (oBuilder.Length > 0)
                        oBuilder.AppendFormat(" {0} ", item.CombineOperator);
                    oBuilder.AppendLine(sFilter);
                }
            }

            if (oBuilder.Length == 0)
                return string.Empty;
            else
                return StrFunc.StrFormat("({0})", oBuilder.ToString());
        }

        /// <summary>
        /// 取得群組過濾條件集合。
        /// </summary>
        /// <param name="filterItems">過濾條件項目集合。</param>
        private GDictionary<GFilterItemCollection> GetGroupFilterItems(GFilterItemCollection filterItems)
        {
            GDictionary<GFilterItemCollection> oList;
            GFilterItemCollection oFilterItems;
            string sGroupNumber;

            oList = new GDictionary<GFilterItemCollection>();
            foreach (GFilterItem filterItem in filterItems)
            {
                sGroupNumber = BaseFunc.CStr(filterItem.GroupNumber);
                if (!oList.ContainsKey(sGroupNumber))
                {
                    oFilterItems = new GFilterItemCollection();
                    oFilterItems.Add(filterItem);
                    oList.Add(sGroupNumber, oFilterItems);
                }
                else
                    oList[sGroupNumber].Add(filterItem);
            }
            return oList;
        }

        /// <summary>
        /// 取得結合運算子。
        /// </summary>
        /// <param name="combineOperator">結合運算子。</param>
        private string GetCombineOperator(ECombineOperator combineOperator)
        {
            switch (combineOperator)
            {
                case ECombineOperator.And: return "AND";
                default: return "OR";
            }
        }

        /// <summary>
        /// 處理單一條件。
        /// </summary>
        /// <param name="filterItem">資料過濾條件項目。</param>
        private string ProcessFilterItem(GFilterItem filterItem)
        {
            GFieldDefine oFieldDefine;
            string sTableName;
            string sFieldName;
            bool bDetail;

            StrFunc.StrSplitFieldName(filterItem.FieldName, out sTableName, out sFieldName);
            if (StrFunc.StrIsEmpty(sTableName))
            {
                sTableName = this.Args.TableName;
                bDetail = false;
            }
            else
            {
                bDetail = true;
            }

            oFieldDefine = this.Args.ProgramDefine.Tables[sTableName].Fields[sFieldName];
            if (BaseFunc.IsNull(oFieldDefine)) { return string.Empty; }

            switch (filterItem.ComparisonOperator)
            {
                case EComparisonOperator.Between:
                    return ProcessBetween(oFieldDefine, filterItem, bDetail);
                case EComparisonOperator.In:
                    return ProcessIn(oFieldDefine, filterItem, bDetail);
                case EComparisonOperator.NotIn:
                    return ProcessIn(oFieldDefine, filterItem, bDetail, false);
                default:
                    return ProcessItem(oFieldDefine, filterItem, bDetail);
            }
        }

        /// <summary>
        /// 處理一般條件。
        /// </summary>
        /// <param name="fieldDefine">欄位定義。</param>
        /// <param name="filterItem">資料過濾條件項目。</param>
        /// <param name="isDetail">是否為明細欄位。</param>
        private string ProcessItem(GFieldDefine fieldDefine, GFilterItem filterItem, bool isDetail)
        {
            string sFieldName;
            string sParameterName;
            string sComparisonOperator;
            object oValue;

            sFieldName = GetFieldName(fieldDefine, isDetail);
            if (StrFunc.StrIsEmpty(sFieldName))
                return string.Empty;

            if (StrFunc.SameText(filterItem.FilterValue, "DB.NULL"))
            {
                return StrFunc.StrFormat("{0} Is Null", sFieldName);
            }
            else if (StrFunc.SameText(filterItem.FilterValue, "DB.NOTNULL"))
            {
                return StrFunc.StrFormat("{0} Is Not Null", sFieldName);
            }
            else
            {
                if (fieldDefine.DbType == EFieldDbType.DateTime &&
                    (filterItem.ComparisonOperator == EComparisonOperator.Equal || filterItem.ComparisonOperator == EComparisonOperator.Like))
                {
                    // DateTime 型別設 Equal 或 Like 皆視為等於，要以區間條件處理
                    return ProcessDateTime(fieldDefine, filterItem, isDetail);
                }
                else
                {
                    sComparisonOperator = filterItem.GetComparisonText();
                    oValue = BaseFunc.CFieldValue(fieldDefine.DbType, filterItem.FilterValue, DBNull.Value);
                    if (BaseFunc.IsDBNull(oValue)) { return string.Empty; }

                    sParameterName = GetDbParameter(fieldDefine, filterItem.ComparisonOperator, oValue);
                    return StrFunc.StrFormat("{0} {1} {2}", sFieldName, sComparisonOperator, sParameterName);
                }
            }
        }

        /// <summary>
        /// 處理多選條件。
        /// </summary>
        /// <param name="fieldDefine">欄位定義。</param>
        /// <param name="filterItem">資料過濾條件項目。</param>
        /// <param name="isDetail">是否為明細欄位。</param>
        /// <param name="isIn">是否為In(反之為Not In)</param>
        private string ProcessIn(GFieldDefine fieldDefine, GFilterItem filterItem, bool isDetail, bool isIn = true)
        {
            string sFieldName;
            string sParameterName;
            string[] oValues;
            string sValue;

            sFieldName = GetFieldName(fieldDefine, isDetail);
            if (StrFunc.StrIsEmpty(sFieldName))
                return string.Empty;

            oValues = StrFunc.StrSplit(filterItem.FilterValue, ",");
            sValue = string.Empty;
            foreach (string value in oValues)
            {
                sParameterName = GetDbParameter(fieldDefine, filterItem.ComparisonOperator, value);
                if (StrFunc.StrIsNotEmpty(sValue)) sValue += ",";
                sValue += sParameterName;
            }

            if (isIn)
                return StrFunc.StrFormat("{0} In ({1})", sFieldName, sValue);
            else
                return StrFunc.StrFormat("{0} Not In ({1})", sFieldName, sValue);
        }

        /// <summary>
        /// 處理區間條件。
        /// </summary>
        /// <param name="fieldDefine">欄位定義。</param>
        /// <param name="filterItem">資料過濾條件項目。</param>
        /// <param name="isDetail">是否為明細欄位。</param>
        private string ProcessBetween(GFieldDefine fieldDefine, GFilterItem filterItem, bool isDetail)
        {
            StringBuilder oBuilder;
            string sFieldName;
            string[] oFilterValues;
            object oMinValue;
            object oMaxValue;
            DateTime oStartDate;
            DateTime oEndDate;
            string sMinParameterName;
            string sMaxParameterName;

            sFieldName = GetFieldName(fieldDefine, isDetail);
            if (StrFunc.StrIsEmpty(sFieldName))
                return string.Empty;

            oBuilder = new StringBuilder();
            oFilterValues = StrFunc.StrSplit(filterItem.FilterValue, ",");
            if (oFilterValues.Length != 2)
                return string.Empty;

            if (fieldDefine.DbType == EFieldDbType.DateTime)
            {
                // 起始日
                oStartDate = BaseFunc.CDateTime(oFilterValues[0]);
                sMinParameterName = GetDbParameter(fieldDefine, filterItem.ComparisonOperator, oStartDate);
                // 終止日+1
                oEndDate = BaseFunc.CDateTime(oFilterValues[1]);
                sMaxParameterName = GetDbParameter(fieldDefine, filterItem.ComparisonOperator, DateFunc.AddDays(oEndDate, 1));
                // 傳回過濾條件，日期區間需大於等於 [起始日] And 小於 [終止日+1]
                return StrFunc.StrFormat("({0} >= {1} And {0} < {2})", sFieldName, sMinParameterName, sMaxParameterName);
            }
            else
            {
                // 起始值
                oMinValue = BaseFunc.CFieldValue(fieldDefine.DbType, oFilterValues[0]);
                sMinParameterName = GetDbParameter(fieldDefine, filterItem.ComparisonOperator, oMinValue);
                // 終止值
                oMaxValue = BaseFunc.CFieldValue(fieldDefine.DbType, oFilterValues[1]);
                sMaxParameterName = GetDbParameter(fieldDefine, filterItem.ComparisonOperator, oMaxValue);
                // 傳回過濾條件
                return StrFunc.StrFormat("({0} >= {1} And {0} <= {2})", sFieldName, sMinParameterName, sMaxParameterName);
            }
        }

        /// <summary>
        /// 處理時間條件(比較運算子為 Equal)。
        /// </summary>
        /// <param name="fieldDefine">欄位定義。</param>
        /// <param name="filterItem">資料過濾條件項目。</param>
        /// <param name="isDetail">是否為明細欄位。</param>
        private string ProcessDateTime(GFieldDefine fieldDefine, GFilterItem filterItem, bool isDetail)
        {
            string sFieldName;
            DateTime oDateValue;
            DateTime oMinValue;
            DateTime oMaxValue;
            string sMinParameterName;
            string sMaxParameterName;

            sFieldName = GetFieldName(fieldDefine, isDetail);
            if (StrFunc.StrIsEmpty(sFieldName))
                return string.Empty;

            // 將過濾值轉型為日期值
            oDateValue = BaseFunc.CDateTime(filterItem.FilterValue).Date;
            // 無法正確轉型為日期值時，過濾條件傳回空字串
            if (BaseFunc.IsEmpty(oDateValue)) { return string.Empty; }

            oMinValue = oDateValue;
            sMinParameterName = GetDbParameter(fieldDefine, filterItem.ComparisonOperator, oMinValue);

            oMaxValue = oDateValue.AddDays(1);
            sMaxParameterName = GetDbParameter(fieldDefine, filterItem.ComparisonOperator, oMaxValue);
            // 大於等於今天 And 小於明天
            return StrFunc.StrFormat("({0} >= {1} And {0} < {2})", sFieldName, sMinParameterName, sMaxParameterName);
        }

        /// <summary>
        /// 取得過濾欄位名稱。
        /// </summary>
        /// <param name="fieldDefine">欄位定義。</param>
        /// <param name="isDetail">是否為明細欄位。</param>
        private string GetFieldName(GFieldDefine fieldDefine, bool isDetail)
        {
            if (BaseFunc.IsNotNull(this.Args.TableJoinProvider))
            {
                if (isDetail)
                    return this.Args.TableJoinProvider.GetDetailDbFieldName(this.DbCommandHelper, fieldDefine);
                else
                    return this.Args.TableJoinProvider.GetDbFieldName(this.DbCommandHelper, fieldDefine);
            }
            else
            {
                return StrFunc.StrFormat("{0}.{1}", "A", this.DbCommandHelper.GetFieldName(fieldDefine.DbFieldName));
            }
        }

        /// <summary>
        /// 取得 Db Parameter 的回傳的參數。
        /// </summary>
        /// <param name="fieldDefine">欄位定義。</param>
        /// <param name="comparison">比較運算子。</param>
        /// <param name="value">過濾條件值。</param>
        private string GetDbParameter(GFieldDefine fieldDefine, EComparisonOperator comparison, object value)
        {
            var oDbParameter = this.DbCommandHelper.AddFilterParameter(fieldDefine);

            if (comparison == EComparisonOperator.Like &&
                (fieldDefine.DbType == EFieldDbType.String || fieldDefine.DbType == EFieldDbType.Text))
            {
                // Like 加入 % 符號
                if (BaseFunc.CStr(value).Contains("%"))
                    oDbParameter.Value = value;
                else
                    oDbParameter.Value = StrFunc.StrFormat("%{0}%", value);
            }
            else
            {
                oDbParameter.Value = value;
            }

            return oDbParameter.ParameterName;
        }
    }
}
