using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder.Order
{
    public abstract  class AbstractOvertimeOrder : Entity<Guid>
    {
        protected Guid StaffId { get; set; }
        protected OvertimeOrderMonth Month { get; set; }
        protected OvertimeOrderStatus Status { get; set; }

    }
}
