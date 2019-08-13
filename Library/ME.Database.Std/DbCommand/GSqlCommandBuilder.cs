using System;
using ME.Define;

namespace ME.Database
{
    /// <summary>
    /// SQL Server 資料庫命令產生器。
    /// </summary>
    public class GSqlCommandBuilder : GBaseDbCommandBuilder, IDbCommandBuilder
    {
        /// <summary>
        /// 建構函式。
        /// </summary>
        /// <param name="sessionGuid">連線識別。</param>
        /// <param name="programDefine">程式定義。</param>
        public GSqlCommandBuilder(Guid sessionGuid, GProgramDefine programDefine)
            : base(sessionGuid, programDefine)
        {
        }
    }
}
