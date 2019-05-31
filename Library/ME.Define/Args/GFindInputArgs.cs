using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// BusinessLogic Find 方法的傳入引數。
    /// </summary>
    public class GFindInputArgs
    {
        /// <summary>
        /// 取消動作
        /// </summary>
        public bool Cancel { get; set; }

        /// <summary>
        /// 參數設定
        /// </summary>
        public GParameterCollection Parameters { get; } = new GParameterCollection();
    }
}
