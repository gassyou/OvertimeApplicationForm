using Attendance;
using System;
using Xunit;
using Xunit.Abstractions;
using Overtime.Model.OvertimeOrder.OrderItem;

namespace OvertimeOrderTest
{
    public class OvertimeTimeRegionTest : TestBase
    {
        public OvertimeTimeRegionTest(ITestOutputHelper tempOutput) : base(tempOutput)
        {
        }

        [Fact]
        public void CannotCreateOvertimeTimeRegion()
        {
            Assert.Null(new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 0, 0), new DateTime(2019, 03, 01, 1, 59, 59)));
        }

        [Fact]
        public void CannotCreateOvertimeRegionWithRoundEndTime()
        {
            Assert.Null(new OvertimeTimeRegion(new DateTime(2019,03,01,3,30,0),new DateTime(2019,03,01,3,59,59)).RoundOvertimeTimeRegionInHalfHour());
        }

        [Fact]
        public void CannotCreateOvertimeTimeRegionWithRoundStartTime()
        {
            
            Assert.Null(new OvertimeTimeRegion(new DateTime(2019, 03, 01, 3, 31, 0), new DateTime(2019, 03, 01, 3, 59, 59)).RoundOvertimeTimeRegionInHalfHour());
        }

        [Fact]
        public void Round1()
        {
            OvertimeTimeRegion o = new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 28, 0), new DateTime(2019, 03, 01, 3, 15, 59));
            OvertimeTimeRegion n = new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 00, 0), new DateTime(2019, 03, 01, 3, 00, 59));
            Assert.Equal(o.RoundOvertimeTimeRegionInHalfHour(), n);
        }

        [Fact]
        public void Round2()
        {
            OvertimeTimeRegion o = new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 59, 0), new DateTime(2019, 03, 01, 3, 59, 59));
            OvertimeTimeRegion n = new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 30, 0), new DateTime(2019, 03, 01, 3, 30, 59));
            Assert.Equal(o.RoundOvertimeTimeRegionInHalfHour(), n);
        }

        [Fact]
        public void NoRound()
        {
            OvertimeTimeRegion o = new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 00, 0), new DateTime(2019, 03, 01, 3, 00, 59));
            OvertimeTimeRegion n = new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 00, 0), new DateTime(2019, 03, 01, 3, 00, 59));
            Assert.Equal(o.RoundOvertimeTimeRegionInHalfHour(), n);
        }

        [Fact]
        public void NoRound1()
        {
            OvertimeTimeRegion o = new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 30, 0), new DateTime(2019, 03, 01, 3, 30, 59));
            OvertimeTimeRegion n = new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 30, 0), new DateTime(2019, 03, 01, 3, 30, 59));
            Assert.Equal(o.RoundOvertimeTimeRegionInHalfHour(), n);

        }

    }
}
