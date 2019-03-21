using System;
using System.Collections.Generic;
using System.Text;
using Common.Model;

namespace Overtime.Model.OvertimeOrder.OrderItem 
{
    public class TransportationFee : ValueObject<TransportationFee> {

        public TransportationFee (string from, string to, TransportationWay way, double fee) 
        {
            AssertionConcern.AssertArgumentNotNull(from,"Transportation from cannot be null.");
            AssertionConcern.AssertArgumentNotNull(to,"Transportation to cannot be null.");
            AssertionConcern.AssertArgumentNotNull(way, "Transportation way cannot be null.");
            AssertionConcern.AssertArgumentNotNull(fee, "Transportation fee cannot be null.");

            this.From = from;
            this.To = to;
            this.Way = way;
            this.Fee = fee;
        }

        public string From { get; private set; }
        public string To { get; private set; }
        public TransportationWay Way { get; private set; }
        public Double Fee { get; private set; }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck () {
            return new List<Object>() { From, To, Way, Fee };
        }
    }
}