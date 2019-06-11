using Overtime.Model.OvertimeOrder.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.Policy
{
    public abstract class OvertimePolicy
    {
        public abstract String Result { get; }
        //TODO: Policy target
        public abstract Boolean Validate(OrderItem orderItem);
    }
}
