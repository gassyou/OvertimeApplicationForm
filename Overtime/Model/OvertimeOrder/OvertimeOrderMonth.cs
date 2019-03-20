using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder
{
    public class OvertimeOrderMonth : ValueObject<OvertimeOrderMonth>
    {
        public OvertimeOrderMonth(int month)
        {
            AssertionConcern.AssertArgumentNotNull(month, "Month can not be null");
            AssertionConcern.AssertArgumentTrue(month < 1, "Month must be between 1 · 12.");
            AssertionConcern.AssertArgumentTrue(month > 12, "Month must be between 1 · 12.");

            this.Month = month;
        }

        public int Month { get; private set; }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new List<Object>() { Month };
        }
    }
}
