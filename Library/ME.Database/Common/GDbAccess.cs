﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using ME.Define;

namespace ME.Database
{
    /// <summary>
    /// 資料庫存取物件。
    /// </summary>
    public class GDbAccess
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public GDbAccess(GDatabaseSettings dbSetting)
        {
            this.DbSetting = dbSetting;
        }

        /// <summary>
        /// 資料庫清單設定
        /// </summary>
        private GDatabaseSettings DbSetting { get; }

        /// <summary>
        /// 資料庫連線
        /// </summary>
        private SqlConnection SqlConnection(string databaseID)
        {
            var item = this.DbSetting.Items[databaseID];
            if (item == null)
                return null;
            var connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};Connection Timeout=30;ConnectRetryCount=6;ConnectRetryInterval=5",
                item.DbServer,
                item.DbName,
                item.LoginID,
                item.Password    
            );
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// 執行資料庫命令，並傳回資料表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string databaseID, string sql)
        {
            var dt = new DataTable();
            dt.Load(this.SqlConnection(databaseID).ExecuteReader(sql, new { }));
            return dt;
        }

        /// <summary>
        /// 執行資料庫命令，並傳回指定型別列舉
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public IEnumerable<T> ExecuteQuery<T>(string databaseID, string sql)
        {
            return this.SqlConnection(databaseID).Query<T>(sql);
        }

        /// <summary>
        /// 執行資料庫命令，並傳回影響資料列數。
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string databaseID, string sql)
        {
            return this.SqlConnection(databaseID).Execute(sql);
        }
    }
}