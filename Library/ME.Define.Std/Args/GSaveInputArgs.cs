using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// BusinessLogic Save 方法的傳入引數。
    /// </summary>
    public class GSaveInputArgs
    {
        /// <summary>
        /// 取消動作
        /// </summary>
        public bool Cancel { get; set; }
        /// <summary>
        /// Entity資料集。
        /// </summary>
        public GEntitySet EntitySet { get; set; }
        /// <summary>
        /// 儲存模式
        /// </summary>
        public ESaveMode SaveMode { get; set; }
    }
}
