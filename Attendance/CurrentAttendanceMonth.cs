using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Attendance
{
    public class CurrentAttendanceMonth: ValueObject<CurrentAttendanceMonth>
    {
        public CurrentAttendanceMonth(DateTime startDay, DateTime endDay)
        {
            AssertionConcern.AssertArgumentNotNull(startDay, "Start day cannot be null.");
            AssertionConcern.AssertArgumentNotNull(endDay, "End day cannot be null.");
            AssertionConcern.AssertArgumentTrue(DateTime.Compare(startDay, endDay) >= 0, "End day must be larger than stard day.");

            this.StartDay = startDay;
            this.EndDay = endDay;
            this.Month = startDay.Month;
        }

        public DateTime StartDay { get; private set; }
        public DateTime EndDay { get; private set; }
        public int Month { get; private set; }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new List<Object>() { StartDay };
        }
    }
}
