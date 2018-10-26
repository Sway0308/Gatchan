using System;

namespace Elementary
{
    /// <summary>
    /// 時間日期相關函式庫。
    /// </summary>
    public class DateFunc
    {
        /// <summary>
        /// 傳回目前時間。
        /// </summary>
        public static DateTime Now()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// 傳回今天日期。
        /// </summary>
        public static DateTime Today()
        {
            return DateTime.Today;
        }

        /// <summary>
        /// 判斷傳入值是否為日期格式。
        /// </summary>
        /// <param name="value">要判斷的值。</param>
        public static bool IsDate(object value)
        {
            DateTime dt;
            return DateTime.TryParse(value.ToString(), out dt);
        }

        /// <summary>
        /// 判斷兩組日期區間是否交疊。(True 為交疊)
        /// </summary>
        /// <param name="beginDate1">第一組的開始時間。</param>
        /// <param name="endDate1">第一組的結束時間。</param>
        /// <param name="beginDate2">第二組的開始時間。</param>
        /// <param name="endDate2">第二組的結束時間。</param>
        public static bool IsOverlap(DateTime beginDate1, DateTime endDate1, DateTime beginDate2, DateTime endDate2)
        {
            return ((endDate2.CompareTo(beginDate1)) > 0 && (endDate1.CompareTo(beginDate2) > 0));
        }

        /// <summary>
        /// 更新日期時間值的時間部分。
        /// </summary>
        /// <param name="value">日期時間值。</param>
        /// <param name="timeValue">要異動時間部分的參考值。</param>
        public static DateTime UpdateTime(DateTime value, DateTime timeValue)
        {
            return new DateTime(value.Year, value.Month, value.Day, timeValue.Hour, timeValue.Minute, timeValue.Second);
        }

        /// <summary>
        /// 更新日期時間值的日期部分。
        /// </summary>
        /// <param name="value">日期時間值。</param>
        /// <param name="dateValue">要異動日期部分的參考值。</param>
        public static DateTime UpdateDate(DateTime value, DateTime dateValue)
        {
            return new DateTime(dateValue.Year, dateValue.Month, dateValue.Day, value.Hour, value.Minute, value.Second);
        }

        /// <summary>
        /// 指定時間加上指定天數。
        /// </summary>
        /// <param name="value">指定時間。</param>
        /// <param name="days">累加天數。</param>
        public static DateTime AddDays(DateTime value, int days)
        {
            return value.AddDays(days);
        }

        /// <summary>
        /// 取得指定年月的該月天數。
        /// </summary>
        /// <param name="year">年月。</param>
        /// <param name="month">月份。</param>
        public static int DaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        /// <summary>
        /// 取得基準日期的該月天數。
        /// </summary>
        /// <param name="value">基準日期。</param>
        public static int DaysInMonth(DateTime value)
        {
            return DaysInMonth(value.Year, value.Month);
        }

        /// <summary>
        /// 以指定日期為基準，取得當季的日期區間。
        /// </summary>
        /// <param name="value">指定日期。</param>
        /// <param name="startDate">傳出起始日期。</param>
        /// <param name="endDate">傳出終止日期。</param>
        private static void GetQuarterRange(DateTime value, out DateTime startDate, out DateTime endDate)
        {
            startDate = DateTime.MinValue;
            endDate = DateTime.MinValue;
            switch (value.Month)
            {
                case 1:
                case 2:
                case 3:
                    startDate = new DateTime(value.Year, 1, 1);
                    endDate = new DateTime(value.Year, 3, 31);
                    break;
                case 4:
                case 5:
                case 6:
                    startDate = new DateTime(value.Year, 4, 1);
                    endDate = new DateTime(value.Year, 6, 30);
                    break;
                case 7:
                case 8:
                case 9:
                    startDate = new DateTime(value.Year, 7, 1);
                    endDate = new DateTime(value.Year, 9, 30);
                    break;
                case 10:
                case 11:
                case 12:
                    startDate = new DateTime(value.Year, 10, 1);
                    endDate = new DateTime(value.Year, 12, 31);
                    break;
            }
        }

        #region CRM 使用方法

        /// <summary>
        /// 傳回參數該月月底。
        /// </summary>
        /// <param name="odate">傳入引數。</param>
        public static DateTime GetEndMonth(DateTime odate)
        {
            return new DateTime(odate.Year, odate.Month, DateTime.DaysInMonth(odate.Year, odate.Month));
        }
        /// <summary>
        /// 傳回參數該月月初。
        /// </summary>
        /// <param name="odate">傳入引數。</param>
        public static DateTime GetBeginMonth(DateTime odate)
        {
            return new DateTime(odate.Year, odate.Month, 1);
        }
        /// <summary>
        /// 回傳相隔天數 odate1，odate2 。
        /// </summary>
        /// <param name="odate1">傳入引數。</param>
        /// <param name="odate2">傳入引數。</param>
        public static int SubtractDate(DateTime odate1, DateTime odate2)
        {
            return odate1.Subtract(odate2).Days;
        }
        /// <summary>
        /// 回傳相隔月 odate1，odate2 。
        /// </summary>
        /// <param name="odate1">傳入引數。</param>
        /// <param name="odate2">傳入引數。</param>
        public static int SubtractMonth(DateTime odate1, DateTime odate2)
        {
            return (odate2.Year - odate1.Year) * 12 + (odate2.Month - odate1.Month) + 1;
        }
        /// <summary>
        /// 判斷是否日期區間 。
        /// </summary>
        /// <param name="oStartDat">起始日。</param>
        /// <param name="oEndDat">結束日。</param>
        /// <param name="oTargetDate">目標日期。</param>
        public static bool IsBetweenDate(DateTime oStartDat, DateTime oEndDat, DateTime oTargetDate)
        {
            if (oTargetDate > oStartDat && oTargetDate < oEndDat)
            {
                return true;
            }
            return false;
        }

        #endregion

        /// <summary>
        /// 將數值轉為TimeSpan格式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TimeSpan ToTimeSpan(object value)
        {
            var time = new TimeSpan();
            if (value is string)
            {
                int hours = BaseFunc.CInt(StrFunc.StrLeft(value.ToString(), 2));
                int minutes = BaseFunc.CInt(StrFunc.StrRight(value.ToString(), 2));
                time = new TimeSpan(hours, minutes, 0);
            }
            else
                time = (TimeSpan)value;

            return time;
        }
    }
}
