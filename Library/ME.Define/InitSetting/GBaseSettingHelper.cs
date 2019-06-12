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
    public class GBaseSettingHelper<T>
    {
        /// <summary>
        /// 定義檔案路徑
        /// </summary>
        protected virtual string SettingFilePath { get; }

        /// <summary>
        /// 定義檔案是否存在
        /// </summary>
        protected bool SettingsExists => FileFunc.FileExists(this.SettingFilePath);

        /// <summary>
        /// 項目保管器
        /// </summary>
        protected GItemKeeper ItemKeeper { get; } = new GItemKeeper();

        /// <summary>
        /// 定義設定
        /// </summary>
        public T Setting => this.ItemKeeper.GetItem(nameof(T), () => {
            if (SettingsExists)
            {
                var json = FileFunc.FileReadAllText(this.SettingFilePath);
                return BaseFunc.JsonToObject<T>(json);
            }

            return Activator.CreateInstance<T>();
        });

        /// <summary>
        /// 取得定義設定Json字串
        /// </summary>
        /// <returns></returns>
        public string GetSettingJson()
            => BaseFunc.ObjectToJson(this.Setting);

        /// <summary>
        /// 儲存設定
        /// </summary>
        public virtual void SaveSetting()
        {
            var json = GetSettingJson();
            FileFunc.FileWriteAllText(this.SettingFilePath, json);
        }

        /// <summary>
        /// 檢視
        /// </summary>
        public virtual string View()
            => this.GetSettingJson();

        /// <summary>
        /// 新增
        /// </summary>
        public virtual void Add()
        { }

        /// <summary>
        /// 修改
        /// </summary>
        public virtual void Edit()
        { }

        /// <summary>
        /// 刪除
        /// </summary>
        public virtual void Delete()
        { }
    }
}
