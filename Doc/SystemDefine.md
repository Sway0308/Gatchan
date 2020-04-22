# 系統定義

### **實體資料庫設定**
| DatabaseId | DatabaseName | DbServer | UserId | Password | Remark |
|--|--|--|--|--|--|
| 資料庫代碼 | 資料庫名稱 | 伺服器 | 登入帳號 | 登入密碼 | 備註 |
| GHM00001 | 鼎恆數位| Azure | sa | 617C354ED55D8561F224E71CEB104EEC 

資料庫代碼為唯一值，八碼字串，GHM+5碼流水號
伺服器+登入帳號+登入密碼=ConnectionString
登入密碼：採用DES字串加密

---

### **公司設定**
| CompanyId | CompanyName | CustomizedId | DatabaseId | Remark |
|--|--|--|--|--|
| 公司代碼 | 公司名稱 | 客製代碼 | 資料庫代碼 | 備註  |
| GHM00001 | 鼎恆數位| G000001 |GHM00001

公司代碼：唯一值，八碼字串，GHM+5碼流水號
不同公司代碼可同一個資料庫代碼，由公司代碼區別不同公司資料
客製代碼：G+5碼流水號

---

### **語系資料表**
| LangId | LangCode | DisplayText  |
|--|--|--|
| 語系代碼 | 地區碼 | 顯示文字 |

語系代碼+地區碼為唯一值
語系代碼：20碼文字，由User自訂
地區碼：依據世界各國語言代碼表設定，ex：zh-tw, zh-cn...

 ---

### **清單資料表**
| ListId | ListValue | DisplayText | LangId |
|--|--|--|--|
| 清單代碼 | 清單值 | 顯示文字 | 語系代碼 |

清單代碼+清單值=唯一值
清單代碼：8碼文字，由User自訂
清單值：數值
顯示文字：顯示給使用者看的文字，預設語系為zh-tw
語系代碼：預設為空，若有設定，取得語系資料表設定顯示文字

---
### **帳號資料表**
| CompanyId | UserId | Password | Remark |
|--|--|--|--|
| 公司代碼 | 帳號 | 密碼 | 備註 |

### **帳號員工對應資料表**
| CompanyId | UserId | TargetId |
|--|--|--|
| 公司代碼 | 帳號 | 員工工號 |

### **角色資料表**
| CompanyId | RoleId | RoleName | RoleType | Remark | 
|--|--|--|--|--|--|--|--|--|--|
| 公司代碼 | 角色代碼 | 角色名稱 | 角色類型 | 備註 | 

### **角色員工對應資料表**
| CompanyId | RoleId | UserId |
|--|--|--|
| 公司代碼 | 角色代碼 | 帳號代碼 |
---

### Permission(權限)
| CompanyId | RoleId | Actions | ViewRange | UserRange | 
|--|--|--|--|--|
| 公司代碼 | 角色代碼 | 動作集合 | 檢視範圍 | 自訂範圍

+ 動作集合，使用等比數列方式記錄動作設定(1, 2, 4, 8)
	0. Executing：是否可視/可執行
	1. Add
	2. Edit
	3. Delete
	4. ~~Print：單據報表~~
	5. ~~Export：資料匯出~~
+ 檢視範圍
	- 個人，部門，部門階層，根部門階層，自訂
	- 個人 >> 新增人員/修改人員 & 表單上的員工編號
+ 自訂部門範圍
+ By 角色做設定

---

### **功能定義**
#### 功能設定
* ProgId：功能代碼=實體資料表名稱，ex: Employee, Department...
* DisplayName：顯示名稱
* Description：描述
#### 資料表設定(一個功能可以有多個資料表設定)
* TableName：資料表名稱，若等於功能代碼，表示為表頭資料表
* DbTableName：實體資料表名稱，預設等於資料表名稱
* DisplayName：顯示名稱
* FilterItems：過濾條件，因應不同功能使用同一個資料表，使用Flag作條件過濾
	* FieldName：欄位名稱
	* FieldValue：欄位值
	* ComparisonOperator：比較運算子
		+ Equal, NotEqual, Less, LessOrEqual, Greater, GreaterOrEqual, Like, Between, In, NotIn
* ~~Indexes：索引設定~~
	+ ~~FieldName：欄位名稱，以逗號分隔不同欄位~~
	+ ~~SorDirection：排序方式，Ascending/Descending~~
* ~~PrimaryKey：主索引，以逗號分隔不同欄位~~
* MasterKey：表身跟表頭關聯用欄位，以逗號分隔不同欄位
#### 欄位定義
* FieldName：欄位名稱
* DisplayName：顯示名稱
* ~~DbType：資料型別, ex: string, boolean~~
* DefaultValue：預設值
* DbDefaultValue：資料表預設值
* ~~Required：必填欄位~~
* AllowNull：允許Null值
* FieldType：資料型態
	* DataField：資料欄位
	* LinkField：關聯欄位
	* VirtualField：虛擬欄位
* ListId：清單代碼，需搭配資料型別=int

---

### **實體資料表欄位**(粗體字表示為PrimaryKey)
#### Required
1. {功能}Id：內碼：**識別碼**，int, auto increasement
2. **{功能}Code：外碼：**
	* 表單：年月日(8碼)+6碼流水號
	* 基本資料：6碼代碼，自訂 or 流水號
3. **CompanyId：公司代碼**
4. InsUserId：新增使用者代碼
5. InsTime：新增時間
6. UptUserId：更新使用者代碼
7. UptTime：更新員工時間
####  表單
8. FormDate：表單日期
####  基本資料
9. {功能}Name：資料名稱
#### 表身
1. **CompanyId：公司代碼**
2. **{表身功能}Id：表身內碼，識別碼，Guid**
3. {表頭功能}Id：表頭內碼

