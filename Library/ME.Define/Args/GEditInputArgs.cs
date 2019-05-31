﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Define
{
    /// <summary>
    /// BusinessLogic Edit 方法的傳入引數。
    /// </summary>
    public class GEditInputArgs
    {
        /// <summary>
        /// 取消動作
        /// </summary>
        public bool Cancel { get; set; }

        /// <summary>
        /// 表單編號
        /// </summary>
        public string FormID { get; set; }
    }
}
