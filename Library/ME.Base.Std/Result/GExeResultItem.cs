using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Base
{
    /// <summary>
    /// 執行結果物件，記錄函式回傳結果物件，執行結果，執行訊息
    /// </summary>
    /// <typeparam name="T">結果物件類型</typeparam>
    public class GExeResultItem<T>
    {
        /// <summary>
        /// 結果物件
        /// </summary>
        public T Item { get; set; }

        /// <summary>
        /// 執行結果
        /// </summary>
        public bool Result { get; set; } = true;

        /// <summary>
        /// 執行訊息
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
