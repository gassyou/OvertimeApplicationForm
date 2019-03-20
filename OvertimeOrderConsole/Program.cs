using Attendance;
using System;

namespace OvertimeOrderConsole
{
    class Program
    {
        static void Main(string[] args)
        {

     


            AttendanceMonth currentDay15 = new AttendanceMonth(15, true);
            Console.WriteLine(currentDay15.GetAttendanceMonthStartDay(2016, 12));
            Console.WriteLine(currentDay15.GetAttendanceMonthEndDay(2016, 12));


            Console.WriteLine(currentDay15.GetAttendanceMonthStartDay(2016, 2));
            Console.WriteLine(currentDay15.GetAttendanceMonthEndDay(2016, 2));




            AttendanceMonth notCurrentDay1 = new AttendanceMonth(1, false);
            Console.WriteLine(notCurrentDay1.GetAttendanceMonthStartDay(2016, 1));
            Console.WriteLine(notCurrentDay1.GetAttendanceMonthEndDay(2016, 1));

        }
    }
}
