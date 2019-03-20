using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder.Order
{
    public class RejectedOvertimeOrder : AbstractOvertimeOrder
    {
        public RejectedOvertimeOrder(Guid id, Guid staffId, OvertimeOrderMonth month, DateTime timeOfRejected)
        {
            AssertionConcern.AssertArgumentNotEmptyGuid(id, "Overtime roder id cannot be null.");
            AssertionConcern.AssertArgumentNotEmptyGuid(staffId, "Overtime order staff id cannot be null.");
            AssertionConcern.AssertArgumentNotNull(timeOfRejected, "Time of submited cannot be null.");

            this.Id = id;
            this.TimeOfRejected = timeOfRejected;
            this.Status = OvertimeOrderStatus.Rejected;
        }
        private DateTime TimeOfRejected { get; set; }

        public InApporvalOvertimeOrder ReSubmit()
        {
            return new InApporvalOvertimeOrder(this.Id, this.StaffId, this.Month, new DateTime());
        }

        public CanceledOvertimeOrder Cancel()
        {
            return new CanceledOvertimeOrder(this.Id, this.StaffId, this.Month, new DateTime());
        }
    }
}
