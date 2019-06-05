using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 資料過濾條件項目集合。
    /// </summary>
    public class GFilterItemCollection : GKeyCollectionBase<GFilterItem>
    {
        /// <summary>
        /// 加入成員。
        /// </summary>
        /// <param name="fieldName">查詢欄位名稱。</param>
        /// <param name="filterValue">查詢值。</param>
        public GFilterItem Add(string fieldName, string filterValue)
        {
            return Add(fieldName, ECombineOperator.And, EComparisonOperator.Equal, filterValue, -1);
        }

        /// <summary>
        /// 加入成員。
        /// </summary>
        /// <param name="fieldName">查詢欄位名稱。</param>
        /// <param name="comparisonOperator">比較運算子。</param>
        /// <param name="filterValue">查詢值。</param>
        public GFilterItem Add(string fieldName, EComparisonOperator comparisonOperator, string filterValue)
        {
            GFilterItem oItem;

            oItem = new GFilterItem();
            oItem.CombineOperator = ECombineOperator.And;
            oItem.FieldName = fieldName;
            oItem.ComparisonOperator = comparisonOperator;
            oItem.FilterValue = filterValue;
            oItem.GroupNumber = -1;
            base.Add(oItem);
            return oItem;
        }

        /// <summary>
        /// 加入成員。
        /// </summary>
        /// <param name="fieldName">查詢欄位名稱。</param>
        /// <param name="combineOperator">結合運算子。</param>
        /// <param name="comparisonOperator">比較運算子。</param>
        /// <param name="filterValue">查詢值。</param>
        /// <param name="groupNumber">條件群組。</param>
        public GFilterItem Add(string fieldName, ECombineOperator combineOperator, EComparisonOperator comparisonOperator, string filterValue, int groupNumber)
        {
            GFilterItem oItem;

            oItem = new GFilterItem();
            oItem.CombineOperator = combineOperator;
            oItem.FieldName = fieldName;
            oItem.ComparisonOperator = comparisonOperator;
            oItem.FilterValue = filterValue;
            oItem.GroupNumber = groupNumber;
            base.Add(oItem);
            return oItem;
        }

        /// <summary>
        /// 加入成員。
        /// </summary>
        /// <param name="items">過濾條件項目集合。</param>
        public void Add(GFilterItemCollection items)
        {
            // 集合無資料則離開
            if (BaseFunc.IsEmpty(items)) { return; }

            foreach (GFilterItem oItem in items)
                Add(oItem);
        }

        /// <summary>
        /// 加入資料過濾條件項目。
        /// </summary>
        /// <param name="filterItem">資料過濾條件項目。</param>
        public override void Add(GFilterItem filterItem)
        {
            string sFieldName, sFilterValue;
            ECombineOperator oCombine;
            EComparisonOperator oComparison;
            int iGroupNumber;

            sFieldName = filterItem.FieldName;
            oComparison = filterItem.ComparisonOperator;
            sFilterValue = filterItem.FilterValue;
            iGroupNumber = filterItem.GroupNumber;

            if (this.Count == 0)
                oCombine = ECombineOperator.And;
            else
                oCombine = filterItem.CombineOperator;

            this.Add(sFieldName, oCombine, oComparison, sFilterValue, iGroupNumber);
        }

        /// <summary>
        /// 依欄位名稱尋找成員。
        /// </summary>
        /// <param name="fieldName">欄位名稱。</param>
        public GFilterItem FindByFieldName(string fieldName)
        {
            foreach (GFilterItem item in this)
            {
                if (StrFunc.SameText(item.FieldName, fieldName))
                    return item;
            }
            return null;
        }

        /// <summary>
        /// 取得篩選值。
        /// </summary>
        /// <param name="dbType">欄位資料型別。</param>
        /// <param name="value">輸入值。</param>
        private string GetFilterValue(EFieldDbType dbType, object value)
        {
            if (dbType == EFieldDbType.DateTime)
            {
                if (BaseFunc.IsNullOrDBNull(value))
                    return string.Empty;
                else
                    return BaseFunc.CDateTime(value).ToString("yyyy/MM/dd");
            }
            else
            {
                return BaseFunc.CStr(value);
            }
        }

        /// <summary>
        /// 移除無查詢值的條件。
        /// </summary>
        /// <returns>把過濾條件值為空的條件剔除。</returns>
        public GFilterItemCollection RemoveEmpty()
        {
            for (int N1 = this.Count - 1; N1 >= 0; N1--)
            {
                var filterItem = this[N1];
                if (StrFunc.StrIsEmpty(filterItem.FilterValue))
                    this.RemoveAt(N1);
            }
            return this;
        }

        /// <summary>
        /// 建立物件複本
        /// </summary>
        /// <returns></returns>
        public GFilterItemCollection Clone()
        {
            GFilterItemCollection items = new GFilterItemCollection();

            foreach (GFilterItem item in this)
                items.Add(item.Clone());
            return items;
        }

        /// <summary>
        /// 移除集合中某個欄位名稱的項目
        /// </summary>
        /// <param name="fieldName"></param>
        public void RemoveFilterItems(string fieldName)
        {
            var fi = FindByFieldName(fieldName);
            if (BaseFunc.IsNull(fi))
                return;
            else
            {
                this.Remove(fi);
                RemoveFilterItems(fieldName);
            }
        }

        /// <summary>
        /// 結合新的資料過濾條件項目集合。
        /// </summary>
        /// <param name="filterItems">欲結合的資料過濾條件項目集合</param>
        /// <param name="changeGroupNumber">改變條件群組編號</param>
        public void CombineFilterItems(GFilterItemCollection filterItems, bool changeGroupNumber = false)
        {
            if (changeGroupNumber)
                foreach (GFilterItem item in this)
                    item.GroupNumber += 1;

            foreach (GFilterItem item in filterItems)
                if (!this.Contains(item))
                    this.Add(item.Clone());
        }

        #region 結合運算子的轉換

        /// <summary>
        /// 轉換結合運算子。
        /// </summary>
        /// <param name="combineOperator">結合運算子字串。</param>
        private ECombineOperator ToCombineOperator(string combineOperator)
        {
            if (combineOperator == "及" || combineOperator.ToUpper() == "AND" || BaseFunc.IsEmpty(combineOperator))
                return ECombineOperator.And;
            else
                return ECombineOperator.Or;
        }

        /// <summary>
        /// 轉換結合運算子。
        /// </summary>
        /// <param name="combineOperator">結合運算子列舉。</param>
        private string ToCombineOperator(ECombineOperator combineOperator)
        {
            if (combineOperator == ECombineOperator.And)
                return "AND";
            else if (combineOperator == ECombineOperator.Or)
                return "OR";

            return string.Empty;
        }

        #endregion

        #region 比較運算子的轉換

        /// <summary>
        /// 轉換比較運算子。
        /// </summary>
        /// <param name="comparisonOperator">比較運算子字串。</param>
        private EComparisonOperator ToComparisonOperator(string comparisonOperator)
        {
            switch (comparisonOperator.ToUpper())
            {
                case "=":
                    return EComparisonOperator.Equal;
                case "<>":
                    return EComparisonOperator.NotEqual;
                case "<":
                    return EComparisonOperator.Less;
                case "<=":
                    return EComparisonOperator.LessOrEqual;
                case ">":
                    return EComparisonOperator.Greater;
                case ">=":
                    return EComparisonOperator.GreaterOrEqual;
                case "LIKE":
                    return EComparisonOperator.Like;
                case "BETWEEN":
                    return EComparisonOperator.Between;
                case "IN":
                    return EComparisonOperator.In;
                case "NOTIN":
                    return EComparisonOperator.NotIn;
                case "VARIABLE":
                    return EComparisonOperator.Variable;
                default:
                    throw new NotSupportedException(comparisonOperator);
            }
        }

        /// <summary>
        /// 轉換比較運算子。
        /// </summary>
        /// <param name="comparisonOperator">比較運算子列舉。</param>
        private string ToComparisonOperator(EComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case EComparisonOperator.Equal: return "=";
                case EComparisonOperator.NotEqual: return "<>";
                case EComparisonOperator.Less: return "<";
                case EComparisonOperator.LessOrEqual: return "<=";
                case EComparisonOperator.Greater: return ">";
                case EComparisonOperator.GreaterOrEqual: return ">=";
                case EComparisonOperator.Like: return "LIKE";
                case EComparisonOperator.Between: return "BETWEEN";
                case EComparisonOperator.In: return "IN";
                case EComparisonOperator.NotIn: return "NOTIN";
                default: // Variable
                    return "VARIABLE";
            }
        }

        #endregion
    }
}
