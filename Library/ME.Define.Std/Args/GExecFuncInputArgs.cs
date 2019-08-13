using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// BusinessLogic.ExecFunc 方法的傳入引數。
    /// </summary>
    public class GExecFuncInputArgs
    {
        /// <summary>
        /// 功能代碼
        /// </summary>
        public string FuncID { get; set; } = string.Empty;
        /// <summary>
        /// 參數設定
        /// </summary>
        public GParameterCollection Parameters { get; } = new GParameterCollection();
    }
}
