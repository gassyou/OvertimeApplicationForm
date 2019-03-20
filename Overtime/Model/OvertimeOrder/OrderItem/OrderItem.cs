using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overtime.Model.OvertimeOrder.OrderItem
{
    public class OrderItem : Entity<Guid>
    {
        public OrderItem(Guid id, Guid orderId, DateTime timeOfCreated)
        {
            AssertionConcern.AssertArgumentNotEmptyGuid(id, "Overtime roder id cannot be null.");
            AssertionConcern.AssertArgumentNotEmptyGuid(orderId, "Overtime order id cannot be null.");
            AssertionConcern.AssertArgumentNotNull(timeOfCreated, "Time of Created cannot be null.");

            this.Id = id;
        }
     
    }
}
