using Common.Model;
using Overtime.Model.OvertimeOrder.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder
{
    public class InApporvalOvertimeOrder : AbstractOvertimeOrder
    {
        public InApporvalOvertimeOrder(Guid id, Guid staffId, OvertimeOrderMonth month, DateTime timeOfSubmited)
        {
            AssertionConcern.AssertArgumentNotEmptyGuid(id, "Overtime roder id cannot be null.");
            AssertionConcern.AssertArgumentNotEmptyGuid(staffId, "Overtime order staff id cannot be null.");
            AssertionConcern.AssertArgumentNotNull(timeOfSubmited, "Time of submited cannot be null.");

            this.Id = id;
            this.TimeOfSubmited = timeOfSubmited;
            this.Status = OvertimeOrderStatus.InApproval;
        }
        private DateTime TimeOfSubmited { get; set; }
    }
}