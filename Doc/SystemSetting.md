# 功能架構

### 基本設定

* ProgramDefine(**ProgId**)為架構核心，不同功能以ProgId互相溝通
* 除了報表外，不建議自己寫SQL語法(**但提供這樣的機制**)，一律透過機制函式取得不同功能資料，可直接過濾權限
* 無特殊邏輯功能，直接透過定義檔，產生CRUD功能，不須另外撰寫BL
* 一律透過BL做CRUD，不自行做Insert/Update/Delete語法
* 特殊邏輯語法，如需取得有歷史性質表單，將語法寫成store procedure
* 欄位都要有預設值(*為了不同功能使用同一個資料表的狀況*)
* 特殊狀況才允許Null存在
* 語系：使用語系資料表
* 清單：使用清單資料表
* namespace：一律為專案名稱，簡化系統架構(**不做過多using**)

### BusinessLogic
1. Add：按下新增時觸發的事件，回傳透過定義而產生的資料集
	* DoBeforeAdd
	* DoAdd
	* DoAfterAdd

2. Edit：按下修改時觸發的事件
	* DoBeforeEdit
	* DoEdit
	* DoAfterEdit

3. Save：按下儲存時觸發的事件
	* DoBeforeSave
	* DoSave
	* DoAfterSave

4. Delete：按下刪除時觸發的事件
	* DoBeforeDelete
	* DoDelete
	* DoAfterDelete

5. Move：單筆資料取得時觸發的事件
	* DoBeforeMove
	* DoMove
	* DoAfterMove

6. Find：清單資料取得時觸發的事件
	* DoBeforeFind
	* DoFind
	* DoAfterFind

7. Select：單筆 & 清單取得時，觸發的事件
	* DoBeforeSelect
	* DoSelect
	* DoAfterSelect

8. FieldValueChange：欄位值異動時所觸發的事件，可透過定義決定是否呼叫
9. ExecFunc：執行自訂函式 
