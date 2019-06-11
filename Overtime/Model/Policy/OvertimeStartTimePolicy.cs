using System;
using System.Collections.Generic;
using System.Text;
using Overtime.Model.OvertimeOrder.OrderItem;

namespace Overtime.Model.Policy
{
    public class OvertimeStartTimePolicy : OvertimePolicy
    {

        string result_ = "";
       public override string Result
        {
            get { return this.result_; }
        }

        public override bool Validate(OrderItem orderItem)
        {
            // TODO: overtime start time policy validate

            if (orderItem.Day.isWorkDay())
            {
                if(orderItem.t)
            }
            this.result_ = "ok";
            return true;
        }
    }
}
