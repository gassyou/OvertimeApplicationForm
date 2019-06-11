using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder.OrderItem
{
    public class OvertimeTimeRegion : ValueObject<OvertimeTimeRegion>
    {
        public OvertimeTimeRegion(DateTime startTime, DateTime endTime)
        {
            AssertionConcern.AssertArgumentNotNull(startTime, "Start time cannot be null.");
            AssertionConcern.AssertArgumentNotNull(endTime, "End time cannot be null.");
            //TODO: 加班到凌晨如何算？
            AssertionConcern.AssertArgumentTrue(DateTime.Compare(startTime, endTime) <= 0, "End time must be larger than stard time.");

            this.StartFullTime = startTime;
            this.EndFullTime = endTime;
            this.StartTime = startTime.Hour.ToString() + ":" + startTime.Minute.ToString();
            this.EndTime = endTime.Hour.ToString() + ":" + endTime.Minute + ToString();

            this.Duration = (endTime - startTime).TotalHours;


        }

        public DateTime StartFullTime { get; private set; }
        public DateTime EndFullTime { get; private set; }
        public String StartTime { get; private set; }
        public String EndTime { get; private set; }
        public double Duration { get; private set; }

        public OvertimeTimeRegion RoundOvertimeTimeRegionInHalfHour()
        {
            DateTime startTime = RoundInHalfHour(this.StartFullTime);
            DateTime endTime = RoundInHalfHour(this.EndFullTime);
            return new OvertimeTimeRegion(startTime, endTime);
        }

        private DateTime RoundInHalfHour(DateTime time)
        {

            int minute = time.Minute;
            if (minute < 30)
            {
                minute = 0;
            }
            if (minute > 30 && minute <= 59)
            {
                minute = 30;
            }

            return new DateTime(time.Year, time.Month, time.Day, time.Hour, minute, time.Second);

        }

        public bool StartTimeLargerThan(DateTime time)
        {
            return true;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new List<Object>() { StartFullTime, EndFullTime };
        }

    }
}
