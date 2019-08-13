using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// 功能層級商業邏輯介面。
    /// </summary>
    public interface IBusinessLogic
    {
        /// <summary>
        /// 取得指定內碼的表單資料。
        /// </summary>
        /// <param name="inputArgs">傳入引數。</param>
        GMoveOutputResult Move(GMoveInputArgs inputArgs);

        /// <summary>
        /// 新增表單資料。
        /// </summary>
        /// <param name="inputArgs">傳入引數。</param>
        GAddOutputResult Add(GAddInputArgs inputArgs);

        /// <summary>
        /// 編輯表單資料。
        /// </summary>
        /// <param name="inputArgs">傳入引數。</param>
        GEditOutputResult Edit(GEditInputArgs inputArgs);

        /// <summary>
        /// 儲存表單資料。
        /// </summary>
        /// <param name="inputArgs">傳入引數。</param>
        GSaveOutputResult Save(GSaveInputArgs inputArgs);

        /// <summary>
        /// 刪除表單資料。
        /// </summary>
        /// <param name="inputArgs">傳入引數。</param>
        GDeleteOutputResult Delete(GDeleteInputArgs inputArgs);

        /// <summary>
        /// 查詢清單資料。
        /// </summary>
        /// <param name="inputArgs">傳入引數。</param>
        GFindOutputResult Find(GFindInputArgs inputArgs);

        /// <summary>
        /// 取得指定資料表符合條件的資料。
        /// </summary>
        GSelectOutputResult Select(GSelectInputArgs inputArgs);

        /// <summary>
        /// 執行自訂方法。
        /// </summary>
        /// <param name="inputArgs">傳入引數。</param>
        GExecFuncOutputResult ExecFunc(GExecFuncInputArgs inputArgs);
    }
}
