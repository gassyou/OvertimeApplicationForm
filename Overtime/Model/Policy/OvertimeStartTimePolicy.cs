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
                DateTime startTime = new DateTime(orderItem.Region.StartFullTime.Year,orderItem.Region.StartFullTime.Month,orderItem.Region.StartFullTime.Day,17,30,00);

                if (orderItem.Region.StartTimeLargerThan(startTime))
                {
                    this.result_ = "ok";
                    return true;
                }
                else
                {
                    this.result_ = "Start time must larger than 17:30 at workday.";
                    return false;
                }
            }
            this.result_ = "ok";
            return true;
        }
    }
}
