using Attendance;
using System;
using Xunit;
using Xunit.Abstractions;

namespace OvertimeOrderTest
{
    public class AttendanceMonthTest : TestBase
    {
        int year2016 = 2016;
        int year2018 = 2018;
        int year2019 = 2019;
        int year2020 = 2020;

        int jan = 1;
        int feb = 2;
        int mar = 3;
        int jun = 6;
        int dec = 12;

        AttendanceMonth currentDay1;
        AttendanceMonth currentDay2;
        AttendanceMonth currentDay15;
        AttendanceMonth currentDay28;


        AttendanceMonth NotCurrentDay1;
        AttendanceMonth NotCuurentDay2;
        AttendanceMonth NotCurrentDay15;
        AttendanceMonth NotCurrentDay28;


        public AttendanceMonthTest(ITestOutputHelper tempOutput) : base(tempOutput)
        {
            currentDay1 = new AttendanceMonth(1, true);
            currentDay2 = new AttendanceMonth(2, true);
            currentDay15 = new AttendanceMonth(15, true);
            currentDay28 = new AttendanceMonth(28, true);



            NotCurrentDay1 = new AttendanceMonth(1, false);
            NotCuurentDay2 = new AttendanceMonth(2, false);
            NotCurrentDay15 = new AttendanceMonth(15, false);
            NotCurrentDay28 = new AttendanceMonth(28, false);


        }

        [Fact]
        public void CurrentDay1Year2016Jan()
        {
            Assert.Equal(new DateTime(year2016, jan, 1), currentDay1.GetAttendanceMonthStartDay(year2016, jan));
            Assert.Equal(new DateTime(year2016, jan, 31), currentDay1.GetAttendanceMonthEndDay(year2016, jan));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2016, jan, new DateTime(year2016, jan, 31)));
        }

        [Fact]
        public void CurrentDay1Year2016Feb()
        {
            Assert.Equal(new DateTime(year2016, feb, 1), currentDay1.GetAttendanceMonthStartDay(year2016, feb));
            Assert.Equal(new DateTime(year2016, feb, 29), currentDay1.GetAttendanceMonthEndDay(year2016, feb));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2016, feb, new DateTime(year2016, feb, 29)));
        }

        [Fact]
        public void CurrentDay1Year2016Mar()
        {
            Assert.Equal(new DateTime(year2016, mar, 1), currentDay1.GetAttendanceMonthStartDay(year2016, mar));
            Assert.Equal(new DateTime(year2016, mar, 31), currentDay1.GetAttendanceMonthEndDay(year2016, mar));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2016, mar, new DateTime(year2016, mar, 31)));
        }

        [Fact]
        public void CurrentDay1Year2016Jun()
        {
            Assert.Equal(new DateTime(year2016, jun, 1), currentDay1.GetAttendanceMonthStartDay(year2016, jun));
            Assert.Equal(new DateTime(year2016, jun, 30), currentDay1.GetAttendanceMonthEndDay(year2016, jun));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2016, jun, new DateTime(year2016, jun, 30)));
        }

        [Fact]
        public void CurrentDay1Year2016Dec()
        {
            Assert.Equal(new DateTime(year2016, dec, 1), currentDay1.GetAttendanceMonthStartDay(year2016, dec));
            Assert.Equal(new DateTime(year2016, dec, 31), currentDay1.GetAttendanceMonthEndDay(year2016, dec));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2016, dec, new DateTime(year2016, dec, 31)));
        }


        // 2018

        [Fact]
        public void CurrentDay1Year2018Jan()
        {
            Assert.Equal(new DateTime(year2018, jan, 1), currentDay1.GetAttendanceMonthStartDay(year2018, jan));
            Assert.Equal(new DateTime(year2018, jan, 31), currentDay1.GetAttendanceMonthEndDay(year2018, jan));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2018, jan, new DateTime(year2018, jan, 31)));
        }

        [Fact]
        public void CurrentDay1Year2018Feb()
        {
            Assert.Equal(new DateTime(year2018, feb, 1), currentDay1.GetAttendanceMonthStartDay(year2018, feb));
            Assert.Equal(new DateTime(year2018, feb, 28), currentDay1.GetAttendanceMonthEndDay(year2018, feb));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2018, feb, new DateTime(year2018, feb, 28)));
        }

        [Fact]
        public void CurrentDay1Year2018Mar()
        {
            Assert.Equal(new DateTime(year2018, mar, 1), currentDay1.GetAttendanceMonthStartDay(year2018, mar));
            Assert.Equal(new DateTime(year2018, mar, 31), currentDay1.GetAttendanceMonthEndDay(year2018, mar));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2018, mar, new DateTime(year2018, mar, 31)));
        }

        [Fact]
        public void CurrentDay1Year2018Jun()
        {
            Assert.Equal(new DateTime(year2018, jun, 1), currentDay1.GetAttendanceMonthStartDay(year2018, jun));
            Assert.Equal(new DateTime(year2018, jun, 30), currentDay1.GetAttendanceMonthEndDay(year2018, jun));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2018, jun, new DateTime(year2018, jun, 30)));
        }

        [Fact]
        public void CurrentDay1Year2018Dec()
        {
            Assert.Equal(new DateTime(year2018, dec, 1), currentDay1.GetAttendanceMonthStartDay(year2018, dec));
            Assert.Equal(new DateTime(year2018, dec, 31), currentDay1.GetAttendanceMonthEndDay(year2018, dec));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2018, dec, new DateTime(year2018, dec, 31)));
        }



        // 2019

        [Fact]
        public void CurrentDay1Year2019Jan()
        {
            Assert.Equal(new DateTime(year2019, jan, 1), currentDay1.GetAttendanceMonthStartDay(year2019, jan));
            Assert.Equal(new DateTime(year2019, jan, 31), currentDay1.GetAttendanceMonthEndDay(year2019, jan));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2019, jan, new DateTime(year2019, jan, 31)));
        }

        [Fact]
        public void CurrentDay1Year2019Feb()
        {
            Assert.Equal(new DateTime(year2019, feb, 1), currentDay1.GetAttendanceMonthStartDay(year2019, feb));
            Assert.Equal(new DateTime(year2019, feb, 28), currentDay1.GetAttendanceMonthEndDay(year2019, feb));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2019, feb, new DateTime(year2019, feb, 28)));
        }

        [Fact]
        public void CurrentDay1Year2019Mar()
        {
            Assert.Equal(new DateTime(year2019, mar, 1), currentDay1.GetAttendanceMonthStartDay(year2019, mar));
            Assert.Equal(new DateTime(year2019, mar, 31), currentDay1.GetAttendanceMonthEndDay(year2019, mar));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2019, mar, new DateTime(year2019, mar, 31)));
        }

        [Fact]
        public void CurrentDay1Year2019Jun()
        {
            Assert.Equal(new DateTime(year2019, jun, 1), currentDay1.GetAttendanceMonthStartDay(year2019, jun));
            Assert.Equal(new DateTime(year2019, jun, 30), currentDay1.GetAttendanceMonthEndDay(year2019, jun));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2019, jun, new DateTime(year2019, jun, 30)));
        }

        [Fact]
        public void CurrentDay1Year2019Dec()
        {
            Assert.Equal(new DateTime(year2019, dec, 1), currentDay1.GetAttendanceMonthStartDay(year2019, dec));
            Assert.Equal(new DateTime(year2019, dec, 31), currentDay1.GetAttendanceMonthEndDay(year2019, dec));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2019, dec, new DateTime(year2019, dec, 31)));
        }


        // 2020

        [Fact]
        public void CurrentDay1Year2020Jan()
        {
            Assert.Equal(new DateTime(year2020, jan, 1), currentDay1.GetAttendanceMonthStartDay(year2020, jan));
            Assert.Equal(new DateTime(year2020, jan, 31), currentDay1.GetAttendanceMonthEndDay(year2020, jan));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2020, jan, new DateTime(year2020, jan, 31)));
        }

        [Fact]
        public void CurrentDay1Year2020Feb()
        {
            Assert.Equal(new DateTime(year2020, feb, 1), currentDay1.GetAttendanceMonthStartDay(year2020, feb));
            Assert.Equal(new DateTime(year2020, feb, 29), currentDay1.GetAttendanceMonthEndDay(year2020, feb));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2020, feb, new DateTime(year2020, feb, 29)));
        }

        [Fact]
        public void CurrentDay1Year2020Mar()
        {
            Assert.Equal(new DateTime(year2020, mar, 1), currentDay1.GetAttendanceMonthStartDay(year2020, mar));
            Assert.Equal(new DateTime(year2020, mar, 31), currentDay1.GetAttendanceMonthEndDay(year2020, mar));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2020, mar, new DateTime(year2020, mar, 31)));
        }

        [Fact]
        public void CurrentDay1Year2020Jun()
        {
            Assert.Equal(new DateTime(year2020, jun, 1), currentDay1.GetAttendanceMonthStartDay(year2020, jun));
            Assert.Equal(new DateTime(year2020, jun, 30), currentDay1.GetAttendanceMonthEndDay(year2020, jun));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2020, jun, new DateTime(year2020, jun, 30)));
        }

        [Fact]
        public void CurrentDay1Year2020Dec()
        {
            Assert.Equal(new DateTime(year2020, dec, 1), currentDay1.GetAttendanceMonthStartDay(year2020, dec));
            Assert.Equal(new DateTime(year2020, dec, 31), currentDay1.GetAttendanceMonthEndDay(year2020, dec));
            Assert.True(currentDay1.IsLastDayOfAttendanceMonth(year2020, dec, new DateTime(year2020, dec, 31)));
        }



        [Fact]
        public void CurrentDay2Year2016Jan()
        {
            Assert.Equal(new DateTime(year2016, jan, 2), currentDay2.GetAttendanceMonthStartDay(year2016, jan));
            Assert.Equal(new DateTime(year2016, feb, 1), currentDay2.GetAttendanceMonthEndDay(year2016, jan));
            Assert.True(currentDay2.IsLastDayOfAttendanceMonth(year2016, jan, new DateTime(year2016, feb, 1)));
        }

        [Fact]
        public void CurrentDay2Year2016Feb()
        {
            Assert.Equal(new DateTime(year2016, feb, 2), currentDay2.GetAttendanceMonthStartDay(year2016, feb));
            Assert.Equal(new DateTime(year2016, mar, 1), currentDay2.GetAttendanceMonthEndDay(year2016, feb));
            Assert.True(currentDay2.IsLastDayOfAttendanceMonth(year2016, feb, new DateTime(year2016, mar, 1)));
        }

        [Fact]
        public void CurrentDay2Year2016Mar()
        {
            Assert.Equal(new DateTime(year2016, mar, 2), currentDay2.GetAttendanceMonthStartDay(year2016, mar));
            Assert.Equal(new DateTime(year2016, 4, 1), currentDay2.GetAttendanceMonthEndDay(year2016, mar));
            Assert.True(currentDay2.IsLastDayOfAttendanceMonth(year2016, mar, new DateTime(year2016, 4, 1)));
        }


        [Fact]
        public void CurrentDay2Year2016Jun()
        {
            Assert.Equal(new DateTime(year2016, jun, 2), currentDay2.GetAttendanceMonthStartDay(year2016, jun));
            Assert.Equal(new DateTime(year2016, 7, 1), currentDay2.GetAttendanceMonthEndDay(year2016, jun));
            Assert.True(currentDay2.IsLastDayOfAttendanceMonth(year2016, jun, new DateTime(year2016, 7, 1)));
        }

        [Fact]
        public void CurrentDay2Year2016Dec()
        {
            Assert.Equal(new DateTime(year2016, dec, 2), currentDay2.GetAttendanceMonthStartDay(year2016, dec));
            Assert.Equal(new DateTime(2017, 1, 1), currentDay2.GetAttendanceMonthEndDay(year2016, dec));
            Assert.True(currentDay2.IsLastDayOfAttendanceMonth(year2016, dec, new DateTime(2017, 1, 1)));
        }

        [Fact]
        public void CurrentDay2Year2018Feb()
        {
            Assert.Equal(new DateTime(year2018, feb, 2), currentDay2.GetAttendanceMonthStartDay(year2018, feb));
            Assert.Equal(new DateTime(year2018, mar, 1), currentDay2.GetAttendanceMonthEndDay(year2018, feb));
            Assert.True(currentDay2.IsLastDayOfAttendanceMonth(year2018, feb, new DateTime(year2018, mar, 1)));
        }


        [Fact]
        public void CurrentDay2Year2019Feb()
        {
            Assert.Equal(new DateTime(year2019, feb, 2), currentDay2.GetAttendanceMonthStartDay(year2019, feb));
            Assert.Equal(new DateTime(year2019, mar, 1), currentDay2.GetAttendanceMonthEndDay(year2019, feb));
            Assert.True(currentDay2.IsLastDayOfAttendanceMonth(year2019, feb, new DateTime(year2019, mar, 1)));
        }

        [Fact]
        public void CurrentDay2Year2020Feb()
        {
            Assert.Equal(new DateTime(year2020, feb, 2), currentDay2.GetAttendanceMonthStartDay(year2020, feb));
            Assert.Equal(new DateTime(year2020, mar, 1), currentDay2.GetAttendanceMonthEndDay(year2020, feb));
            Assert.True(currentDay2.IsLastDayOfAttendanceMonth(year2020, feb, new DateTime(year2020, mar, 1)));
        }


        // current15


        [Fact]
        public void CurrentDay15Year2016Jan()
        {
            Assert.Equal(new DateTime(year2016, jan, 15), currentDay15.GetAttendanceMonthStartDay(year2016, jan));
            Assert.Equal(new DateTime(year2016, feb, 14), currentDay15.GetAttendanceMonthEndDay(year2016, jan));
            Assert.True(currentDay15.IsLastDayOfAttendanceMonth(year2016, jan, new DateTime(year2016, feb, 14)));
        }

        [Fact]
        public void CurrentDay15Year2016Feb()
        {
            Assert.Equal(new DateTime(year2016, feb, 15), currentDay15.GetAttendanceMonthStartDay(year2016, feb));
            Assert.Equal(new DateTime(year2016, mar, 14), currentDay15.GetAttendanceMonthEndDay(year2016, feb));
            Assert.True(currentDay15.IsLastDayOfAttendanceMonth(year2016, feb, new DateTime(year2016, mar, 14)));
        }

        [Fact]
        public void CurrentDay15Year2016Mar()
        {
            Assert.Equal(new DateTime(year2016, mar, 15), currentDay15.GetAttendanceMonthStartDay(year2016, mar));
            Assert.Equal(new DateTime(year2016, 4, 14), currentDay15.GetAttendanceMonthEndDay(year2016, mar));
            Assert.True(currentDay15.IsLastDayOfAttendanceMonth(year2016, mar, new DateTime(year2016, 4, 14)));
        }


        [Fact]
        public void CurrentDay15Year2016Jun()
        {
            Assert.Equal(new DateTime(year2016, jun, 15), currentDay15.GetAttendanceMonthStartDay(year2016, jun));
            Assert.Equal(new DateTime(year2016, 7, 14), currentDay15.GetAttendanceMonthEndDay(year2016, jun));
            Assert.True(currentDay15.IsLastDayOfAttendanceMonth(year2016, jun, new DateTime(year2016, 7, 14)));
        }

        [Fact]
        public void CurrentDay15Year2016Dec()
        {
            Assert.Equal(new DateTime(year2016, dec, 15), currentDay15.GetAttendanceMonthStartDay(year2016, dec));
            Assert.Equal(new DateTime(2017, 1, 14), currentDay15.GetAttendanceMonthEndDay(year2016, dec));
            Assert.True(currentDay15.IsLastDayOfAttendanceMonth(year2016, dec, new DateTime(2017, 1, 14)));
        }

        [Fact]
        public void CurrentDay15Year2018Feb()
        {
            Assert.Equal(new DateTime(year2018, feb, 15), currentDay15.GetAttendanceMonthStartDay(year2018, feb));
            Assert.Equal(new DateTime(year2018, mar, 14), currentDay15.GetAttendanceMonthEndDay(year2018, feb));
            Assert.True(currentDay15.IsLastDayOfAttendanceMonth(year2018, feb, new DateTime(year2018, mar, 14)));
        }


        [Fact]
        public void CurrentDay15Year2019Feb()
        {
            Assert.Equal(new DateTime(year2019, feb, 15), currentDay15.GetAttendanceMonthStartDay(year2019, feb));
            Assert.Equal(new DateTime(year2019, mar, 14), currentDay15.GetAttendanceMonthEndDay(year2019, feb));
            Assert.True(currentDay15.IsLastDayOfAttendanceMonth(year2019, feb, new DateTime(year2019, mar, 14)));
        }

        [Fact]
        public void CurrentDay15Year2020Feb()
        {
            Assert.Equal(new DateTime(year2020, feb, 15), currentDay15.GetAttendanceMonthStartDay(year2020, feb));
            Assert.Equal(new DateTime(year2020, mar, 14), currentDay15.GetAttendanceMonthEndDay(year2020, feb));
            Assert.True(currentDay15.IsLastDayOfAttendanceMonth(year2020, feb, new DateTime(year2020, mar, 14)));
        }

        // current 28

        [Fact]
        public void CurrentDay28Year2016Jan()
        {
            Assert.Equal(new DateTime(year2016, jan, 28), currentDay28.GetAttendanceMonthStartDay(year2016, jan));
            Assert.Equal(new DateTime(year2016, feb, 27), currentDay28.GetAttendanceMonthEndDay(year2016, jan));
            Assert.True(currentDay28.IsLastDayOfAttendanceMonth(year2016, jan, new DateTime(year2016, feb, 27)));
        }

        [Fact]
        public void CurrentDay28Year2016Feb()
        {
            Assert.Equal(new DateTime(year2016, feb, 28), currentDay28.GetAttendanceMonthStartDay(year2016, feb));
            Assert.Equal(new DateTime(year2016, mar, 27), currentDay28.GetAttendanceMonthEndDay(year2016, feb));
            Assert.True(currentDay28.IsLastDayOfAttendanceMonth(year2016, feb, new DateTime(year2016, mar, 27)));
        }

        [Fact]
        public void CurrentDay28Year2016Mar()
        {
            Assert.Equal(new DateTime(year2016, mar, 28), currentDay28.GetAttendanceMonthStartDay(year2016, mar));
            Assert.Equal(new DateTime(year2016, 4, 27), currentDay28.GetAttendanceMonthEndDay(year2016, mar));
            Assert.True(currentDay28.IsLastDayOfAttendanceMonth(year2016, mar, new DateTime(year2016, 4, 27)));
        }


        [Fact]
        public void CurrentDay28Year2016Jun()
        {
            Assert.Equal(new DateTime(year2016, jun, 28), currentDay28.GetAttendanceMonthStartDay(year2016, jun));
            Assert.Equal(new DateTime(year2016, 7, 27), currentDay28.GetAttendanceMonthEndDay(year2016, jun));
            Assert.True(currentDay28.IsLastDayOfAttendanceMonth(year2016, jun, new DateTime(year2016, 7, 27)));
        }

        [Fact]
        public void CurrentDay28Year2016Dec()
        {
            Assert.Equal(new DateTime(year2016, dec, 28), currentDay28.GetAttendanceMonthStartDay(year2016, dec));
            Assert.Equal(new DateTime(2017, 1, 27), currentDay28.GetAttendanceMonthEndDay(year2016, dec));
            Assert.True(currentDay28.IsLastDayOfAttendanceMonth(year2016, dec, new DateTime(2017, 1, 27)));
        }

        [Fact]
        public void CurrentDay28Year2018Feb()
        {
            Assert.Equal(new DateTime(year2018, feb, 28), currentDay28.GetAttendanceMonthStartDay(year2018, feb));
            Assert.Equal(new DateTime(year2018, mar, 27), currentDay28.GetAttendanceMonthEndDay(year2018, feb));
            Assert.True(currentDay28.IsLastDayOfAttendanceMonth(year2018, feb, new DateTime(year2018, mar, 27)));
        }


        [Fact]
        public void CurrentDay28Year2019Feb()
        {
            Assert.Equal(new DateTime(year2019, feb, 28), currentDay28.GetAttendanceMonthStartDay(year2019, feb));
            Assert.Equal(new DateTime(year2019, mar, 27), currentDay28.GetAttendanceMonthEndDay(year2019, feb));
            Assert.True(currentDay28.IsLastDayOfAttendanceMonth(year2019, feb, new DateTime(year2019, mar, 27)));
        }

        [Fact]
        public void CurrentDay28Year2020Feb()
        {
            Assert.Equal(new DateTime(year2020, feb, 28), currentDay28.GetAttendanceMonthStartDay(year2020, feb));
            Assert.Equal(new DateTime(year2020, mar, 27), currentDay28.GetAttendanceMonthEndDay(year2020, feb));
            Assert.True(currentDay28.IsLastDayOfAttendanceMonth(year2020, feb, new DateTime(year2020, mar, 27)));
        }


        // NoCurrent

        [Fact]
        public void NotCurrentDay1Year2016Jan()
        {
            Assert.Equal(new DateTime(2015, 12, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2016, jan));
            Assert.Equal(new DateTime(2015, 12, 31), NotCurrentDay1.GetAttendanceMonthEndDay(year2016, jan));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2016, jan, new DateTime(2015, 12, 31)));
        }

        [Fact]
        public void NotCurrentDay1Year2016Feb()
        {
            Assert.Equal(new DateTime(year2016, jan, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2016, feb));
            Assert.Equal(new DateTime(year2016, jan, 31), NotCurrentDay1.GetAttendanceMonthEndDay(year2016, feb));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2016, feb, new DateTime(year2016, jan, 31)));
        }

        [Fact]
        public void NotCurrentDay1Year2016Mar()
        {
            Assert.Equal(new DateTime(year2016, feb, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2016, mar));
            Assert.Equal(new DateTime(year2016, feb, 29), NotCurrentDay1.GetAttendanceMonthEndDay(year2016, mar));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2016, mar, new DateTime(year2016, feb, 29)));
        }

        [Fact]
        public void NotCurrentDay1Year2016Jun()
        {
            Assert.Equal(new DateTime(year2016, 5, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2016, jun));
            Assert.Equal(new DateTime(year2016, 5, 31), NotCurrentDay1.GetAttendanceMonthEndDay(year2016, jun));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2016, jun, new DateTime(year2016, 5, 31)));
        }

        [Fact]
        public void NotCurrentDay1Year2016Dec()
        {
            Assert.Equal(new DateTime(year2016, 11, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2016, dec));
            Assert.Equal(new DateTime(year2016, 11, 30), NotCurrentDay1.GetAttendanceMonthEndDay(year2016, dec));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2016, dec, new DateTime(year2016, 11, 30)));
        }

        [Fact]
        public void NotCurrentDay1Year2018Feb()
        {
            Assert.Equal(new DateTime(year2018, 1, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2018, feb));
            Assert.Equal(new DateTime(year2018, 1, 31), NotCurrentDay1.GetAttendanceMonthEndDay(year2018, feb));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2018, feb, new DateTime(year2018, 1, 31)));
        }

        [Fact]
        public void NotCurrentDay1Year2018Mar()
        {
            Assert.Equal(new DateTime(year2018, feb, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2018, mar));
            Assert.Equal(new DateTime(year2018, feb, 28), NotCurrentDay1.GetAttendanceMonthEndDay(year2018, mar));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2018, mar, new DateTime(year2018,feb, 28)));
        }

        [Fact]
        public void NotCurrentDay1Year2019Feb()
        {
            Assert.Equal(new DateTime(year2019, 1, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2019, feb));
            Assert.Equal(new DateTime(year2019, 1, 31), NotCurrentDay1.GetAttendanceMonthEndDay(year2019, feb));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2019, feb, new DateTime(year2019, 1, 31)));
        }

        [Fact]
        public void NotCurrentDay1Year2019Mar()
        {
            Assert.Equal(new DateTime(year2019, feb, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2019, mar));
            Assert.Equal(new DateTime(year2019, feb, 28), NotCurrentDay1.GetAttendanceMonthEndDay(year2019, mar));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2019, mar, new DateTime(year2019, feb, 28)));
        }


        [Fact]
        public void NotCurrentDay1Year2020Feb()
        {
            Assert.Equal(new DateTime(year2020, 1, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2020, feb));
            Assert.Equal(new DateTime(year2020, 1, 31), NotCurrentDay1.GetAttendanceMonthEndDay(year2020, feb));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2020, feb, new DateTime(year2020, 1, 31)));
        }

        [Fact]
        public void NotCurrentDay1Year2020Mar()
        {
            Assert.Equal(new DateTime(year2020, feb, 1), NotCurrentDay1.GetAttendanceMonthStartDay(year2020, mar));
            Assert.Equal(new DateTime(year2020, feb, 29), NotCurrentDay1.GetAttendanceMonthEndDay(year2020, mar));
            Assert.True(NotCurrentDay1.IsLastDayOfAttendanceMonth(year2020, mar, new DateTime(year2020, feb, 29)));
        }

        // NoCurrentDay15
        [Fact]
        public void NotCurrentDay15Year2016Jan()
        {
            Assert.Equal(new DateTime(2015, 12, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2016, jan));
            Assert.Equal(new DateTime(2016, 1, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2016, jan));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2016, jan, new DateTime(2016, 1, 14)));
        }

        [Fact]
        public void NotCurrentDay15Year2016Feb()
        {
            Assert.Equal(new DateTime(year2016, jan, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2016, feb));
            Assert.Equal(new DateTime(year2016, feb, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2016, feb));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2016, feb, new DateTime(year2016, feb, 14)));
        }

        [Fact]
        public void NotCurrentDay15Year2016Mar()
        {
            Assert.Equal(new DateTime(year2016, feb, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2016, mar));
            Assert.Equal(new DateTime(year2016, mar, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2016, mar));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2016, mar, new DateTime(year2016, mar, 14)));
        }

        [Fact]
        public void NotCurrentDay15Year2016Jun()
        {
            Assert.Equal(new DateTime(year2016, 5, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2016, jun));
            Assert.Equal(new DateTime(year2016, jun, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2016, jun));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2016, jun, new DateTime(year2016, jun, 14)));
        }

        [Fact]
        public void NotCurrentDay15Year2016Dec()
        {
            Assert.Equal(new DateTime(year2016, 11, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2016, dec));
            Assert.Equal(new DateTime(year2016, dec, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2016, dec));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2016, dec, new DateTime(year2016, dec, 14)));
        }

        [Fact]
        public void NotCurrentDay15Year2018Feb()
        {
            Assert.Equal(new DateTime(year2018, 1, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2018, feb));
            Assert.Equal(new DateTime(year2018, feb, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2018, feb));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2018, feb, new DateTime(year2018, feb, 14)));
        }

        [Fact]
        public void NotCurrentDay15Year2018Mar()
        {
            Assert.Equal(new DateTime(year2018, feb, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2018, mar));
            Assert.Equal(new DateTime(year2018, mar, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2018, mar));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2018, mar, new DateTime(year2018, mar, 14)));
        }

        [Fact]
        public void NotCurrentDay15Year2019Feb()
        {
            Assert.Equal(new DateTime(year2019, 1, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2019, feb));
            Assert.Equal(new DateTime(year2019, feb, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2019, feb));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2019, feb, new DateTime(year2019, feb, 14)));
        }

        [Fact]
        public void NotCurrentDay15Year2019Mar()
        {
            Assert.Equal(new DateTime(year2019, feb, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2019, mar));
            Assert.Equal(new DateTime(year2019, mar, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2019, mar));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2019, mar, new DateTime(year2019, mar, 14)));
        }


        [Fact]
        public void NotCurrentDay15Year2020Feb()
        {
            Assert.Equal(new DateTime(year2020, 1, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2020, feb));
            Assert.Equal(new DateTime(year2020, 2, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2020, feb));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2020, feb, new DateTime(year2020, 2, 14)));
        }

        [Fact]
        public void NotCurrentDay15Year2020Mar()
        {
            Assert.Equal(new DateTime(year2020, feb, 15), NotCurrentDay15.GetAttendanceMonthStartDay(year2020, mar));
            Assert.Equal(new DateTime(year2020, mar, 14), NotCurrentDay15.GetAttendanceMonthEndDay(year2020, mar));
            Assert.True(NotCurrentDay15.IsLastDayOfAttendanceMonth(year2020, mar, new DateTime(year2020, mar, 14)));
        }

        // NoCurrentDay28
        [Fact]
        public void NotCurrentDay28Year2016Jan()
        {
            Assert.Equal(new DateTime(2015, 12, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2016, jan));
            Assert.Equal(new DateTime(2016, 1, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2016, jan));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2016, jan, new DateTime(2016, 1, 27)));
        }

        [Fact]
        public void NotCurrentDay28Year2016Feb()
        {
            Assert.Equal(new DateTime(year2016, jan, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2016, feb));
            Assert.Equal(new DateTime(year2016, feb, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2016, feb));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2016, feb, new DateTime(year2016, feb, 27)));
        }

        [Fact]
        public void NotCurrentDay28Year2016Mar()
        {
            Assert.Equal(new DateTime(year2016, feb, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2016, mar));
            Assert.Equal(new DateTime(year2016, mar, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2016, mar));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2016, mar, new DateTime(year2016, mar, 27)));
        }

        [Fact]
        public void NotCurrentDay28Year2016Jun()
        {
            Assert.Equal(new DateTime(year2016, 5, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2016, jun));
            Assert.Equal(new DateTime(year2016, jun, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2016, jun));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2016, jun, new DateTime(year2016, jun, 27)));
        }

        [Fact]
        public void NotCurrentDay28Year2016Dec()
        {
            Assert.Equal(new DateTime(year2016, 11, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2016, dec));
            Assert.Equal(new DateTime(year2016, dec, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2016, dec));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2016, dec, new DateTime(year2016, dec, 27)));
        }

        [Fact]
        public void NotCurrentDay28Year2018Feb()
        {
            Assert.Equal(new DateTime(year2018, 1, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2018, feb));
            Assert.Equal(new DateTime(year2018, feb, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2018, feb));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2018, feb, new DateTime(year2018, feb, 27)));
        }

        [Fact]
        public void NotCurrentDay28Year2018Mar()
        {
            Assert.Equal(new DateTime(year2018, feb, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2018, mar));
            Assert.Equal(new DateTime(year2018, mar, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2018, mar));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2018, mar, new DateTime(year2018, mar, 27)));
        }

        [Fact]
        public void NotCurrentDay28Year2019Feb()
        {
            Assert.Equal(new DateTime(year2019, 1, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2019, feb));
            Assert.Equal(new DateTime(year2019, feb, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2019, feb));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2019, feb, new DateTime(year2019, feb, 27)));
        }

        [Fact]
        public void NotCurrentDay28Year2019Mar()
        {
            Assert.Equal(new DateTime(year2019, feb, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2019, mar));
            Assert.Equal(new DateTime(year2019, mar, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2019, mar));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2019, mar, new DateTime(year2019, mar, 27)));
        }


        [Fact]
        public void NotCurrentDay28Year2020Feb()
        {
            Assert.Equal(new DateTime(year2020, 1, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2020, feb));
            Assert.Equal(new DateTime(year2020, 2, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2020, feb));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2020, feb, new DateTime(year2020, 2, 27)));
        }

        [Fact]
        public void NotCurrentDay28Year2020Mar()
        {
            Assert.Equal(new DateTime(year2020, feb, 28), NotCurrentDay28.GetAttendanceMonthStartDay(year2020, mar));
            Assert.Equal(new DateTime(year2020, mar, 27), NotCurrentDay28.GetAttendanceMonthEndDay(year2020, mar));
            Assert.True(NotCurrentDay28.IsLastDayOfAttendanceMonth(year2020, mar, new DateTime(year2020, mar, 27)));
        }

    }
}
