using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Overtime.Model.Policy;

namespace Overtime.Model.OvertimeOrder.OrderItem
{
    public class OrderItem : Entity<Guid>
    {
        public OrderItem(
            Guid id,
            Guid orderId,
            //TODO: Use Applicant class or ID
            Guid staffId, 
            OvertimeDay day,
            OvertimeTimeRegion region,
            TransportationFee transportFee,
            OvertimeNote note,
            DateTime timeOfCreated)
        {
            AssertionConcern.AssertArgumentNotEmptyGuid(id, "Overtime roder id cannot be null.");
            AssertionConcern.AssertArgumentNotEmptyGuid(orderId, "Overtime order id cannot be null.");
            AssertionConcern.AssertArgumentNotEmptyGuid(staffId,"Staff id cannot be null.");
            AssertionConcern.AssertArgumentNotNull(day,"Day cannot be null");
            AssertionConcern.AssertArgumentNotNull(region, "Region cannot be bull");
            AssertionConcern.AssertArgumentNotNull(Note,"Note cannot be null");
            AssertionConcern.AssertArgumentNotNull(timeOfCreated, "Time of Created cannot be null.");

            this.Id = id;
            this.OrderId = orderId;
            this.StaffId = staffId;
            this.Day = day;
            this.Region = region;
            this.TransportFee = transportFee;
            this.Note = note;
            this.TimeOfCreated = timeOfCreated;
        }

        public Guid OrderId {  get; private set; }
        public Guid StaffId { get; private set; }
        public OvertimeDay Day { get; private set; }
        public OvertimeTimeRegion Region { get; private set; }
        public TransportationFee TransportFee { get; private set; }
        public OvertimeNote Note { get; private set; }

        public DateTime TimeOfCreated { get; private set; }


        public bool IsComplianceWithCompanyPolicy(List<OvertimePolicy> policies)
        {
            if (policies == null)
            {
                throw new ArgumentNullException(nameof(policies));
            }
            if (policies.Count <= 0) 
            {
                return true;
            }
            foreach(OvertimePolicy policy in policies) 
            {
                //TODO: 判断此申请者是否属于，这个政策的对象内？或者另外的思路是，一个申请者，可以有哪些符合条件的政策
                if(!policy.Validate(this)) 
                {
                    throw new SystemException(policy.Result);       
                }

            }
            return true;
        }

        public void CalculateMealAllowance()
        {
            //TODO: calculate meal allowance
             
        }


     
    }
}


// 添加一条加班条目的流程+
// 1. 这个加班条目属于哪个加班单的
// 2. 该条加班条目中的时间，是否和其他重复？
// 3. 这个加班条目属于哪位员工
// 4. 这个员工拥有哪些加班政策
// 5. 这个加班条目是否符合这些政策
// 6，计算各项加班补贴
// 7. 数据保存

// 思考题
// 加班政策是可以流动变化的。所以，是否需要讲加班单和当时申请的政策，进行关联保存？注意，不是和加班项目关联保存。
// 