using ME.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Define
{
    /// <summary>
    /// 欄位定義集合
    /// </summary>
    [Serializable]
    public class GFieldDefineCollection : GKeyCollectionBase<GFieldDefine>
    {
        /// <summary>
        /// 找出關連主欄位的欄位定義
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public GFieldDefine FindActiveLinkFieldDefine(string fieldName)
        {
            var fieldDefine = this[fieldName];
            if (fieldDefine == null)
                return null;

            return this[fieldDefine.FieldName];
        }
    }
}
