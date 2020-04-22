>程式定義
1. ProgramDefine - 程式定義
	* TableDefine - 資料表定義
		* FieldDefine - 欄位定義
2. 程式定義包含
	* 程式代碼
	* 1~N 個資料表集合
	* BL Type (動態Create用)
3. 資料表定義包含
	* 資料表名稱
	* 實體資料表名稱
	* 欄位定義集合
4. 欄位定義包含
	* 資料欄位，該資料表的真正欄位
	* 關聯欄位，與其他Table關聯(Left Join)而來的欄位
5. 

>底層商業邏輯類別庫(*使用 **參數式物件**，避免參數頻繁異動導致修改成本增加*)

IBusinessLogic
1. Add
2. Edit
3. Save
4. Delete
5. Move
6. Find
7. Select
8. FieldValueChange
9. ExecFunc

BaseBusinessLogic : IBusinessLogic
10. Add：按下新增時觸發的事件，回傳透過定義而產生的資料集
	* DoBeforeAdd
	* DoAdd
	* DoAfterAdd

11. Edit：按下修改時觸發的事件
	* DoBeforeEdit
	* DoEdit
	* DoAfterEdit

12. Save：按下儲存時觸發的事件
	* DoBeforeSave
	* DoSave
	* DoAfterSave

13. Delete：按下刪除時觸發的事件
	* DoBeforeDelete
	* DoDelete
	* DoAfterDelete

14. Move：取得單筆資料時觸發的事件
	* DoBeforeMove
	* DoMove
	* DoAfterMove

15. Find：取得清單資料時觸發的事件
	* DoBeforeFind
	* DoFind
	* DoAfterFind

16. Select：單筆 & 清單取得時，觸發的事件
	* DoBeforeSelect
	* DoSelect
	* DoAfterSelect

17. FieldValueChange：欄位值異動時所觸發的事件，可透過定義決定是否呼叫
18. ExecFunc：執行自訂函式 

BusinessFunc：機制提供各功能資料取得(**Move, Find, Select**)
UpdateItems：異動資料集合
	* UpdateField
	* UpdateControl
