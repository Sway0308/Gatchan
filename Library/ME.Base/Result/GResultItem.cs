using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Base
{
    /// <summary>
    /// 回傳結果物件，記錄函式回傳結果，同時成功/失敗、回傳異常、訊息、參數集合
    /// </summary>
    public class GResultItem
    {
        /// <summary>
        /// 執行結果
        /// </summary>
        public bool Result { get; set; }

        /// <summary>
        /// 訊息
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// 參數集合
        /// </summary>
        public GParameterCollection Parameters { get; } = new GParameterCollection();

        /// <summary>
        /// 異常
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// 物件描述
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Result={Result}, Message={Message}";
        }
    }
}
