using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// BusinessLogic.ExecFunc 方法的傳出結果。
    /// </summary>
    public class GExecFuncOutputResult
    {
        /// <summary>
        /// 參數設定
        /// </summary>
        public GParameterCollection Parameters { get; } = new GParameterCollection();
    }
}
