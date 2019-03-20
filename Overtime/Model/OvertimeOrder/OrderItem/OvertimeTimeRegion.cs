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
            AssertionConcern.AssertArgumentTrue(DateTime.Compare(startTime, endTime) >= 0, "End time must be larger than stard time.");

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

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            throw new NotImplementedException();
        }
    }
}
