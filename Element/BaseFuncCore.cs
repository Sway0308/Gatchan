using System;
using System.Collections;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Elementary.Core
{
    /// <summary>
    /// 基礎函式庫。
    /// </summary>
    public class BaseFuncCore
    {
        #region 判斷空值相關方法

        /// <summary>
        /// 是傳入值否為 Null 值。
        /// </summary>
        /// <param name="value">要判斷的值。</param>
        public static bool IsNull(object value)
        {
            return (value == null);
        }

        /// <summary>
        /// 判斷傳入值是否不為 Null 值。
        /// </summary>
        /// <param name="value">要判斷的值。</param>
        public static bool IsNotNull(object value)
        {
            return (value != null);
        }

        /// <summary>
        /// 是否為空值，Null 或 DBNull 皆視為空值。
        /// </summary>
        /// <param name="value">要判斷的值。</param>
        public static bool IsEmpty(object value)
        {
            if (value is string)
                return StrFuncCore.StrIsEmpty(BaseFuncCore.CStr(value));
            else
                return IsNull(value);
        }

        /// <summary>
        /// 判斷 Guid 值是否為空值。
        /// </summary>
        /// <param name="value">要判斷的 Guid 值。</param>
        public static bool IsEmpty(Guid value)
        {
            return (value == Guid.Empty);
        }

        /// <summary>
        /// 判斷日期值是否為空值。
        /// </summary>
        /// <param name="value">要判斷的日期值。</param>
        public static bool IsEmpty(DateTime value)
        {
            // 日期為 Null、DbNull、DateTime.MinValue 皆視為空值
            return (IsNull(value) || DateTime.Compare(value, DateTime.MinValue) == 0);
        }

        /// <summary>
        /// 判斷 IDictionary 型別的集合是否無資料。
        /// </summary>
        /// <param name="value">要判斷的集合。</param>
        public static bool IsEmpty(IDictionary value)
        {
            if ((value != null) && (value.Count != 0))
                return false;
            else
                return true;
        }

        #endregion

        #region 型別轉換相關方法

        /// <summary>
        /// 轉型為文字。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        /// <param name="defaultValue">無法成功轉型的預設值。</param>
        public static string CStr(object value, string defaultValue)
        {
            //若為 Null 或 DBNull 值，則傳回預設值
            if (BaseFuncCore.IsNull(value))
            {
                return defaultValue;
            }
            //若為列舉型別，則傳回列舉名稱
            if (value is Enum)
            {
                return GetEnumName((Enum)value);
            }
            //轉型為文字
            //return (string)value;
            return Convert.ToString(value);
        }

        /// <summary>
        /// 轉型為文字。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static string CStr(object value)
        {
            return BaseFuncCore.CStr(value, string.Empty);
        }

        /// <summary>
        /// 轉型為文字，並去除左右空白。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static string CStrTrim(object value)
        {
            return BaseFuncCore.CStr(value).Trim();
        }

        /// <summary>
        /// 轉型為布林值。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static bool CBool(object value)
        {
            if (IsNull(value)) { return false; }

            if (value is string)
            {
                return CBool(CStr(value));
            }
            else
            {
                return Convert.ToBoolean(value);
            }
        }

        /// <summary>
        /// 轉型為 Guid 值。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static Guid CGuid(string value)
        {
            if (IsEmpty(value) || StrFuncCore.SameText(value, "*"))
                return Guid.Empty;
            else
            {
                var result = Guid.Empty;
                if (Guid.TryParse(value, out result))
                    return result;
                else
                    return result;
            }
        }

        /// <summary>
        /// 轉型為 Guid 值。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static Guid CGuid(object value)
        {
            if (IsEmpty(value))
                return Guid.Empty;
            else if (value is Guid)
                return (Guid)value;
            else if (value is string)
                return CGuid((string)value);
            else
                return Guid.Empty;
        }

        /// <summary>
        /// 字串轉型為布林值。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static bool CBool(string value)
        {
            if (StrFuncCore.SameText(value, "Y"))
                return true;
            else if (StrFuncCore.SameText(value, "T"))
                return true;
            else if (StrFuncCore.SameText(value, "true"))
                return true;
            else if (StrFuncCore.SameText(value, "1"))
                return true;
            else if (StrFuncCore.SameText(value, "是"))
                return true;
            else if (StrFuncCore.SameText(value, "真"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 轉型為列舉值。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        /// <param name="type">列舉型別。</param>
        public static object CEnum(string value, Type type)
        {
            return Enum.Parse(type, value, true);
        }

        /// <summary>
        /// 轉型為列舉值。
        /// </summary>
        /// <typeparam name="T">列舉型別。</typeparam>
        /// <param name="value">要轉型的值。</param>
        public static T CEnum<T>(string value)
        {
            return (T)CEnum(value, typeof(T));
        }

        /// <summary>
        /// 轉型為列舉值。
        /// </summary>
        /// <typeparam name="T">列舉型別。</typeparam>
        /// <param name="value">要轉型的值。</param>
        /// <param name="defaultValue">無法轉型成功的預設值。</param>
        public static T CEnum<T>(string value, object defaultValue)
        {
            try
            {
                return CEnum<T>(value);
            }
            catch
            {
                return (T)defaultValue;
            }
        }

        /// <summary>
        /// 字串轉16進位字串。
        /// </summary>
        /// <param name="value">要轉的值。</param>
        public static string CHex(string value)
        {
            char[] oChars;
            string sReturnValue;

            if (StrFuncCore.StrIsEmpty(value)) return string.Empty;

            sReturnValue = string.Empty;
            oChars = value.ToCharArray();

            foreach (char letter in oChars)
            {
                sReturnValue += Convert.ToString(letter, 16);
            }
            return sReturnValue;
        }

        /// <summary>
        /// 判斷是否為數值。
        /// </summary>
        /// <param name="value">要判斷的值。</param>
        public static bool IsNumeric(object value)
        {
            Regex NumberPattern = new Regex("[^0-9.-]");
            return !NumberPattern.IsMatch(CStr(value));
        }

        /// <summary>
        /// 轉型為數值。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static object CNum(object value)
        {
            // Null 傳回 0
            if (IsNull(value)) { return 0; }
            // 針對文字型別做處理
            if (value is string)
            {
                // 空字串傳回 0
                if (StrFuncCore.StrIsEmpty(value)) { return 0; }
                // 若為數值先轉型為 Double 型別，防止有小數點無法轉型為整數
                if (BaseFuncCore.IsNumeric(value)) { value = Convert.ToDouble(value); }
            }

            if (!BaseFuncCore.IsNumeric(value))
                throw new Exception(value + " 無法轉型為數值");

            return value;
        }

        /// <summary>
        /// 轉型為整數。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static int CInt(object value)
        {
            return Convert.ToInt32(CNum(value));
        }

        /// <summary>
        /// 轉型為長整數。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static long CLong(object value)
        {
            return Convert.ToInt64(CNum(value));
        }

        /// <summary>
        /// 轉型為單精確浮點數。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static float CFloat(object value)
        {
            return Convert.ToSingle(CNum(value));
        }

        /// <summary>
        /// 轉型為雙精確浮點數。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static double CDouble(object value)
        {
            return Convert.ToDouble(CNum(value));
        }

        /// <summary>
        /// 轉型為 Decimal 浮點數。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static decimal CDecimal(object value)
        {
            return Convert.ToDecimal(CNum(value));
        }

        /// <summary>
        /// 轉型為日期值。
        /// </summary>
        /// <param name="value">要轉型的值。</param>
        public static DateTime CDateTime(object value)
        {
            try
            {
                if (value is DateTime)
                    return (DateTime)value;
                else if (value is string)
                {
                    var provider = CultureInfo.InvariantCulture;
                    var style = DateTimeStyles.None;
                    var result = default(DateTime);
                    var a = DateTime.TryParseExact(value as string, "yyyy/MM/dd HH:mm:ss", provider, style, out result);
                    if (a)
                        return result;
                    else
                        return Convert.ToDateTime(value as string);
                }
                else
                    return Convert.ToDateTime(value);

            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// 轉型成時間間格值
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static TimeSpan CTimeSpan(string time)
        {
            var result = new TimeSpan();

            if (StrFuncCore.StrIsNotEmpty(time))
            {
                int hours = BaseFuncCore.CInt(StrFuncCore.StrLeft(time, 2));
                int minutes = BaseFuncCore.CInt(StrFuncCore.StrRight(time, 2));
                result = new TimeSpan(hours, minutes, 0);
            }

            return result;
        }

        #endregion

        /// <summary>
        /// 取得列舉成員的名稱。
        /// </summary>
        /// <param name="value">列舉值。</param>
        public static string GetEnumName(Enum value)
        {
            return Enum.GetName(value.GetType(), value);
        }

        /// <summary>
        /// 判斷列舉值是否有指定成員。
        /// </summary>
        /// <param name="value">列舉值。</param>
        /// <param name="flag">要判斷的成員。</param>
        public static bool HasFlag(Enum value, Enum flag)
        {
            return value.HasFlag(flag);
        }

        /// <summary>
        /// 判斷列舉值是否有指定成員之一。
        /// </summary>
        /// <param name="value">列舉值。</param>
        /// <param name="flag1">要判斷的成員一。</param>
        /// <param name="flag2">要判斷的成員二。</param>
        public static bool HasFlag(Enum value, Enum flag1, Enum flag2)
        {
            if (HasFlag(value, flag1) || HasFlag(value, flag2))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 產生新的 Guid 值。
        /// </summary>
        public static System.Guid NewGuid()
        {
            return System.Guid.NewGuid();
        }

        /// <summary>
        /// 產生新的 Guid 值字串。
        /// </summary>
        public static string NewGuidString()
        {
            return NewGuid().ToString();
        }

        /// <summary>
        /// 以預設建構函式，建立指定類別的執行個體。
        /// </summary>
        /// <typeparam name="T">要建立執行個體的型別。</typeparam>
        public static T CreateInstance<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        /// <summary>
        /// 若傳入值為 Null 時，則建立指定類別的執行個體。
        /// </summary>
        /// <typeparam name="T">要建立執行個體的型別。</typeparam>
        /// <param name="value">要判斷的執行個體。</param>
        public static void NullCreateInstance<T>(ref T value)
        {
            if (IsNull(value))
                value = CreateInstance<T>();
        }

        /// <summary>
        /// 將 Byte 陣列轉換為十六進位字串。
        /// </summary>
        /// <param name="buffer">Byte 陣列。</param>
        public static string ByteToHex(byte[] buffer)
        {
            StringBuilder oBuffer;

            oBuffer = new StringBuilder();
            for (int i = 0; i < buffer.Length; i++)
            {
                oBuffer.Append(buffer[i].ToString("X2")); // hex format
            }
            return oBuffer.ToString();
        }

        /// <summary>
        /// 取得下一個流水號。
        /// </summary>
        /// <param name="value">目前編號。</param>
        /// <param name="numberBase">流水號進位基底，2至36進位。</param>
        public static string GetNextID(string value, int numberBase)
        {
            string sValue;
            char[] oBaseValues;
            int iBaseValue;

            oBaseValues = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            sValue = StrFuncCore.StrTrim(value);

            for (int N1 = sValue.Length - 1; N1 >= 0; N1--)
            {
                iBaseValue = Array.IndexOf(oBaseValues, sValue[N1]);
                if (iBaseValue != -1 && iBaseValue < numberBase - 1)
                {
                    return StrFuncCore.StrFormat("{0}{1}{2}", StrFuncCore.StrLeft(sValue, N1), oBaseValues[iBaseValue + 1], StrFuncCore.StrSubstring(sValue, N1 + 1));
                }
                else
                {
                    // 需要進位，將目前位數歸零
                    if (iBaseValue != -1 && iBaseValue < numberBase)
                    {
                        sValue = StrFuncCore.StrFormat("{0}{1}{2}", StrFuncCore.StrLeft(sValue, N1), "0", StrFuncCore.StrSubstring(sValue, N1 + 1));
                    }
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// 驗證Email格式正確性
        /// </summary>
        /// <param name="email">email</param>
        /// <returns></returns>
        public static bool ValidateEmailFormat(string email)
        {
            Match match = Regex.Match(email, "^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");
            return match.Success;
        }

        /// <summary>
        /// 隨機取得一個整數值。
        /// </summary>
        /// <param name="min">最小值。</param>
        /// <param name="max">最大值。</param>
        public static int RndInt(int min, int max)
        {
            Random oRnd = new Random(Guid.NewGuid().GetHashCode());
            int iValue = 0;

            iValue = BaseFuncCore.CInt(oRnd.Next(min, max));
            return iValue;
        }

        /// <summary>
        /// 由參考字串中隨機取得一個字元。
        /// </summary>
        /// <param name="s">參考字串。</param>
        public static string RndWord(string s)
        {
            int iIndex = 0;

            iIndex = RndInt(1, s.Length);
            return StrFuncCore.StrSubstring(s, iIndex, 1);
        }

        /// <summary>
        /// 由參考字串中隨機取得一組指定長度字串。
        /// </summary>
        /// <param name="s">參考字串。</param>
        /// <param name="length">隨機字串的長度。</param>
        public static string RndString(string s, int length)
        {
            StringBuilder oBuffer = default(StringBuilder);
            int N1 = 0;

            oBuffer = new StringBuilder();
            for (N1 = 1; N1 <= length; N1++)
            {
                oBuffer.Append(RndWord(s));
            }
            return oBuffer.ToString();
        }

        /// <summary>
        /// 取得亂數產生的英文字母大小寫與數字組合的字串
        /// </summary>
        /// <param name="length">要產生的亂數字串長度</param>
        /// <returns></returns>
        public static string GetRandomString(int length)
        {
            string s = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string code = RndString(s, length);
            return code;
        }

        /// <summary>
        /// 將浮點數四捨五入至指定位數。
        /// </summary>
        /// <param name="value">浮點數。</param>
        /// <param name="digits">小數位數。</param>
        public static double Round(double value, int digits)
        {
            // 預設為偶捨基入，加上 MidpointRounding.AwayFromZero 才是一般認知的四捨五入
            return Math.Round(value, digits, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 十進位數值四捨五入至指定位數。
        /// </summary>
        /// <param name="value">十進位數值。</param>
        /// <param name="digits">小數位數。</param>
        public static decimal Round(decimal value, int digits)
        {
            // 預設為偶捨基入，加上 MidpointRounding.AwayFromZero 才是一般認知的四捨五入
            return Math.Round(value, digits, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 無條件捨去至指定位數
        /// </summary>
        /// <param name="value">數值</param>
        /// <param name="digit">小數位數</param>
        /// <returns></returns>
        public static double Floor(double value, int digit)
        {
            if (digit < 0) { return Math.Floor(value); }
            var pow = Math.Pow(10, digit);
            var sign = value >= 0 ? 1 : -1;
            return sign * Math.Floor(sign * value * pow) / pow;
        }

        /// <summary>
        /// 無條件進位至指定位數
        /// </summary>
        /// <param name="value">數值</param>
        /// <param name="digit">小數位數</param>
        /// <returns></returns>
        public static double Ceiling(double value, int digit)
        {
            if (digit < 0) { return Math.Floor(value); }
            var pow = Math.Pow(10, digit);
            var sign = value >= 0 ? 1 : -1;
            return sign * Math.Ceiling(sign * value * pow) / pow;
        }
    }
}
