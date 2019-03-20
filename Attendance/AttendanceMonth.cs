using Common.Model;
using System;
using System.Collections.Generic;

namespace Attendance
{
    public class AttendanceMonth : ValueObject<AttendanceMonth>
    {

        public AttendanceMonth(int startDay, Boolean isFromCurrentMonth = true)
        {
            AssertionConcern.AssertArgumentNotNull(startDay, "Start day cannot be null.");
            AssertionConcern.AssertArgumentTrue(startDay > 0 && startDay < 29 , "Start Day must be between 1 - 29.");
     
            this.StartDay = startDay;
            this.IsFromCurrentMonth = isFromCurrentMonth;
        }

        public int StartDay { get; private set; }
        public Boolean IsFromCurrentMonth { get; private set; }


        public CurrentAttendanceMonth GetCurrentAttendanceMonth(int year, int month)
        {
            DateTime startDay = GetAttendanceMonthStartDay(year,month);
            DateTime endDay = GetAttendanceMonthEndDay(year, month);
            return new CurrentAttendanceMonth(startDay,endDay);
        }

        public DateTime GetAttendanceMonthStartDay(int year, int month)
        {
            int day = StartDay;

            //if (IsFromCurrentMonth && IsFebruary(month) && StartDay > 28)
            //{
            //    day = CalculateFebruaryDays(year);
            //}

            //if (IsFromCurrentMonth && IsLunarMonth(month) && StartDay > 30)
            //{
            //    day = 30;
            //}

            DateTime startDay = new DateTime(year, month, day);
            if (!IsFromCurrentMonth)
            {
                startDay=startDay.AddMonths(-1);
            }

            return startDay;
        }


        public DateTime GetAttendanceMonthEndDay(int year, int month)
        {
            //DateTime startDay = GetAttendanceMonthStartDay(year,month);

            //int daySpan = 30;
            //if (IsFebruary(month))
            //{
            //    daySpan = CalculateFebruaryDays(year) - 1;
            //}

            //if (IsLunarMonth(month))
            //{
            //    daySpan = 29;
            //}

            //if (StartDay > startDay.Day)
            //{
            //    daySpan = daySpan + (StartDay - startDay.Day);
            //}

            //return startDay.AddDays(daySpan);

            return GetAttendanceMonthStartDay(year, month).AddMonths(1).AddDays(-1);
            
        }

        public Boolean IsLastDayOfAttendanceMonth(int year,int month,DateTime day)
        {
            DateTime endDay = GetAttendanceMonthEndDay(year,month);
            return endDay == day;
        }


        private bool IsLeapYear(int year)
        {
            return year % 4 == 0;
        }

        private bool IsLunarMonth(int month)
        {
            return month == 4 || month == 6 || month == 9 || month == 11;
        }

        private bool IsFebruary(int month)
        {
            return month == 2;
        }

        private int CalculateFebruaryDays(int year)
        {
            return IsLeapYear(year) ? 29 : 28;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new List<Object>() { StartDay };
        }
    }
}
