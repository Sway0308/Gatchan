using ME.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 定義設定輔助器
    /// </summary>
    public class GBaseDefineFileHelper<T> where T : IDefineFile
    {
        /// <summary>
        /// 定義檔案路徑
        /// </summary>
        protected virtual string DefineFilePath { get; }

        /// <summary>
        /// 定義檔案是否存在
        /// </summary>
        protected bool DefineFileExists => FileFunc.FileExists(this.DefineFilePath);

        /// <summary>
        /// 定義儲存輔助器
        /// </summary>
        protected GSaveDefineHelper SaveDefineHelper { get; } = new GSaveDefineHelper();

        /// <summary>
        /// 儲存設定
        /// </summary>
        public virtual void SaveDefine(T defineFile)
        {
            this.SaveDefineHelper.SaveDefine(defineFile);
        }

        /// <summary>
        /// 取得定義
        /// </summary>
        /// <returns></returns>
        public virtual T GetDefine(params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
