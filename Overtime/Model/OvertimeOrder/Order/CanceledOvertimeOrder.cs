using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder
{
    public class CanceledOvertimeOrder : Entity<Guid>
    {
        public CanceledOvertimeOrder(Guid id, Guid staffId, OvertimeOrderMonth month, DateTime timeOfCanceled)
        {
            AssertionConcern.AssertArgumentNotEmptyGuid(id, "Overtime roder id cannot be null.");
            AssertionConcern.AssertArgumentNotEmptyGuid(staffId, "Overtime order staff id cannot be null.");
            AssertionConcern.AssertArgumentNotNull(timeOfCanceled, "Time of cancel cannot be null.");


            this.Id = id;
            this.StaffId = staffId;
            this.Month = month;
            this.TimeOfCanceled = timeOfCanceled;
            this.Status = OvertimeOrderStatus.Canceled;
        }

        private Guid StaffId { get; set; }
        private OvertimeOrderMonth Month { get; set; }
        private DateTime TimeOfCanceled { get; set; }
        private OvertimeOrderStatus Status { get; set; }
    }
}

