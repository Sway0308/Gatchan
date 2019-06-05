using ME.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Define
{
    /// <summary>
    /// 資料表定義集合
    /// </summary>
    public class GTableDefineCollection : GKeyCollectionBase<GTableDefine>
    {
        /// <summary>
        /// 建構函式。
        /// </summary>
        /// <param name="programDefine">程式定義。</param>
        public GTableDefineCollection(GProgramDefine programDefine)
            : base(programDefine)
        { }
    }
}
