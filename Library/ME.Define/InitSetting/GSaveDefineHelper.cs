using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 儲存定義檔案輔助器
    /// </summary>
    public class GSaveDefineHelper
    {
        /// <summary>
        /// 儲存定義檔案
        /// </summary>
        /// <param name="defineFile"></param>
        /// <returns></returns>
        public void SaveDefine(IDefineFile defineFile)
        {
            if (defineFile == null)
                throw new GException("Define is null");

            var json = JsonFunc.ObjectToJson(defineFile);
            FileFunc.FileWriteAllText(defineFile.GetDefineFilePath(), json, true);
        }
    }
}
