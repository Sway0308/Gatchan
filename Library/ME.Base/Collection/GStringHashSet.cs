using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Base
{
    /// <summary>
    /// 不允許重覆的字串集合，字串忽略大小寫。
    /// </summary>
    public class GStringHashSet : HashSet<string>
    {
        #region 建構函式

        /// <summary>
        /// 建構函式。
        /// </summary>
        public GStringHashSet() : base(StringComparer.InvariantCultureIgnoreCase)
        { }

        /// <summary>
        /// 建構函式。
        /// </summary>
        /// <param name="s">字串。</param>
        /// <param name="delimiter">分隔符號。</param>
        public GStringHashSet(string s, string delimiter) : this()
        {
            this.Add(s, delimiter);
        }

        #endregion

        /// <summary>
        /// 將集合成員依分隔符號組成字串。
        /// </summary>
        /// <param name="delimiter">分隔符號。</param>
        public string ToString(string delimiter)
        {
            StringBuilder oBuffer;

            oBuffer = new StringBuilder();
            foreach (string item in this)
            {
                if (oBuffer.Length > 0) { oBuffer.Append(delimiter); }
                oBuffer.Append(item);
            }
            return oBuffer.ToString();
        }

        /// <summary>
        /// 加入字串陣列為成員。
        /// </summary>
        /// <param name="array">字串陣列。</param>
        public void Add(string[] array)
        {
            foreach (string sValue in array)
                this.Add(sValue);
        }

        /// <summary>
        /// 加入集合字串為成員。
        /// </summary>
        /// <param name="s">字串。</param>
        /// <param name="delimiter">分隔符號。</param>
        public void Add(string s, string delimiter)
        {
            string[] oValues;

            if (StrFunc.StrIsEmpty(s)) { return;  }

            oValues = StrFunc.StrSplit(s, delimiter);
            foreach (string value in oValues)
            {
                if (!this.Contains(value))
                    this.Add(value);
            }
        }
    }
}
