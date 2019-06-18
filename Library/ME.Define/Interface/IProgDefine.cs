using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 功能定義介面
    /// </summary>
    public interface IProgDefine : ISystemDefine
    {
        /// <summary>
        /// 程式定義
        /// </summary>
        string ProgID { get; set; }
    }
}
