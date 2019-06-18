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
            if (defineFile is GDatabaseSettings)
                FileFunc.FileWriteAllText(SysDefineSettingName.DbSettingPath, json, true);
            else if (defineFile is ISystemDefine)
            {
                var systemID = (defineFile as ISystemDefine).SystemID;

                if (defineFile is GProgramSetting)
                    FileFunc.FileWriteAllText(SysDefineSettingName.ProgramSettingFilePath(systemID), json, true);
                else if (defineFile is IProgDefine)
                {
                    var progID = (defineFile as IProgDefine).ProgID;
                    if (defineFile is GDbTableDefine)
                        FileFunc.FileWriteAllText(SysDefineSettingName.DbTableDefineFilePath(systemID, progID), json, true);
                    else if (defineFile is GProgramDefine)
                        FileFunc.FileWriteAllText(SysDefineSettingName.ProgramDefineFilePath(systemID, progID), json, true);
                }
            }
        }
    }
}
