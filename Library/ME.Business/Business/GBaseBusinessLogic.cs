using ME.Cahce;
using ME.Define;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Business
{
    /// <summary>
    /// 基底功能層級商業邏輯元件
    /// </summary>
    public class GBaseBusinessLogic : GBaseDbAccess
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="progID">程式代碼</param>
        public GBaseBusinessLogic(string progID)
        {
            this.ProgID = progID;
            this.ProgramDefine = CacheFunc.GetProgramDefine("HUM", this.ProgID);
        }

        /// <summary>
        /// 程式代碼
        /// </summary>
        public string ProgID { get; }
        /// <summary>
        /// 程式定義
        /// </summary>
        public GProgramDefine ProgramDefine { get; }

        /// <summary>
        /// 資料庫代碼
        /// </summary>
        public string DatabaseID { get; } = "001";
    }
}
