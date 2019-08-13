using System;
using ME.Define;

namespace ME.Database
{
    /// <summary>
    /// Oracle 資料庫命令產生器。
    /// </summary>
    public class GOracleCommandBuilder : GBaseDbCommandBuilder, IDbCommandBuilder
    {
        /// <summary>
        /// 建構函式。
        /// </summary>
        /// <param name="sessionGuid">連線識別。</param>
        /// <param name="programDefine">程式定義。</param>
        public GOracleCommandBuilder(Guid sessionGuid, GProgramDefine programDefine)
            : base(sessionGuid, programDefine)
        {}

    }
}
