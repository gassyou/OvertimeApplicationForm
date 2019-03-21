//using Attendance;
using Overtime.Model.OvertimeOrder.OrderItem;
using System;

namespace OvertimeOrderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //AttendanceMonth currentDay15 = new AttendanceMonth(15, true);
            //Console.WriteLine(currentDay15.GetAttendanceMonthStartDay(2016, 12));
            //Console.WriteLine(currentDay15.GetAttendanceMonthEndDay(2016, 12));


            //Console.WriteLine(currentDay15.GetAttendanceMonthStartDay(2016, 2));
            //Console.WriteLine(currentDay15.GetAttendanceMonthEndDay(2016, 2));




            //AttendanceMonth notCurrentDay1 = new AttendanceMonth(1, false);
            //Console.WriteLine(notCurrentDay1.GetAttendanceMonthStartDay(2016, 1));
            //Console.WriteLine(notCurrentDay1.GetAttendanceMonthEndDay(2016, 1));

            Console.WriteLine(DateTime.Compare(new DateTime(2019, 03, 01, 02, 59, 00), new DateTime(2019, 03, 01, 01, 59, 00)));
            Console.WriteLine(DateTime.Compare(new DateTime(2019, 03, 01, 2, 28, 0), new DateTime(2019, 03, 01, 3, 15, 59)));
            OvertimeTimeRegion o = new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 28, 0), new DateTime(2019, 03, 01, 3, 15, 59));
            OvertimeTimeRegion n = new OvertimeTimeRegion(new DateTime(2019, 03, 01, 2, 00, 0), new DateTime(2019, 03, 01, 3, 00, 59));
            o.RoundOvertimeTimeRegionInHalfHour();

        
            Console.WriteLine("aaa");


        }
    }
}
