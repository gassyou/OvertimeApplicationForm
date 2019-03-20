using Attendance;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder.OrderItem
{
    public class OvertimeDay : ValueObject<OvertimeDay>
    {
        private static readonly string[] _week = new string[] { "日", "一", "二", "三", "四", "五", "六" };

        public OvertimeDay(DateTime day)
        {
            AssertionConcern.AssertArgumentNotNull(day, "Overtime Day cannot be null.");

            this.Day = day;
            this.DayOfWeek = _week[Convert.ToInt32(day.ToString("d"))].ToString();
        }

        public DateTime Day { get; private set; }
        public String DayOfWeek { get; private set; }

        public bool isInCurrentMonth(CurrentAttendanceMonth currentMonth)
        {
            return this.Day.Month == currentMonth.Month ? true : false;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new List<Object>() { Day };
        }
    }


}
