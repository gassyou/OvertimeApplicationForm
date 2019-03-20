using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder
{
    public enum OvertimeOrderStatus
    {
        NewBorn = 0,
        Canceled = 2,
        InApproval = 3,
        Accepted = 4,
        Rejected = 5
    }
}
