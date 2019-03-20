using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder.Order
{
    public class AcceptedOvertimeOrder:AbstractOvertimeOrder
    {
        public AcceptedOvertimeOrder(Guid id, Guid staffId, OvertimeOrderMonth month, DateTime timeOfAccepted)
        {
            AssertionConcern.AssertArgumentNotEmptyGuid(id, "Overtime roder id cannot be null.");
            AssertionConcern.AssertArgumentNotEmptyGuid(staffId, "Overtime order staff id cannot be null.");
            AssertionConcern.AssertArgumentNotNull(timeOfAccepted, "Time of submited cannot be null.");

            this.Id = id;
            this.TimeOfAccepted = timeOfAccepted;
            this.Status = OvertimeOrderStatus.Accepted;
        }
        private DateTime TimeOfAccepted { get; set; }
    }
}
