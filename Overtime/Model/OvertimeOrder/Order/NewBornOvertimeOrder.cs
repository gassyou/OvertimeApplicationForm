using Common.Model;
using Overtime.Model.OvertimeOrder.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder
{
    public class NewBornOvertimeOrder : AbstractOvertimeOrder
    {
        
        public NewBornOvertimeOrder(Guid id, Guid staffId, OvertimeOrderMonth month, DateTime timeOfCreation)
        {
            AssertionConcern.AssertArgumentNotEmptyGuid(id, "Overtime roder id cannot be null.");
            AssertionConcern.AssertArgumentNotEmptyGuid(staffId, "Overtime order staff id cannot be null.");
            AssertionConcern.AssertArgumentNotNull(timeOfCreation, "Time of creation cannot be null.");

            this.Id = id;
            this.StaffId = staffId;
            this.Month = month;
            this.TimeOfCreation = timeOfCreation;
            this.Status = OvertimeOrderStatus.NewBorn;

        }

        private DateTime TimeOfCreation { get; set; }

        public InApporvalOvertimeOrder ConfirmAndSubmit()
        {
            return new InApporvalOvertimeOrder(this.Id, this.StaffId, this.Month, new DateTime());
        }

        public CanceledOvertimeOrder Cancel()
        {
            return new CanceledOvertimeOrder(this.Id, this.StaffId, this.Month, new DateTime());
        }
    }
}
