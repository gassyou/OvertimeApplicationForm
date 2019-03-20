using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder
{
    public class OvertimeOrderCreated
    {
        public OvertimeOrderCreated(Guid overtimeOrderId, Guid staffId, DateTime timeOfCreation)
        {
            AssertionConcern.AssertArgumentNotEmptyGuid(overtimeOrderId, "OvertimeOrder id cannot be null.");
            AssertionConcern.AssertArgumentNotEmptyGuid(staffId, "Staff id cannot be null.");
            AssertionConcern.AssertArgumentNotNull(timeOfCreation, "Time of creation cannot be null");

            this.OvertimeOrderId = overtimeOrderId;
            this.StaffId = staffId;
            this.TimeOfCreation = timeOfCreation;
        }

        public Guid OvertimeOrderId {get; private set;}
        public Guid StaffId { get; private set; }
        public DateTime TimeOfCreation { get; private set; }
    }
}
