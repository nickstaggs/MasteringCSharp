using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class DateTest
    {
        // System.DateTime (.NET 1.0)
        // System.TimeSpan (.NET 1.0)
            // Standard 100 nanoseconds, tick
        // System.DateTimeOffset (.NET 2.0SP1/ .NET 3.5)
        // System.TimeZoneInfo (.NET 3.5)

        [Test]
        public void TimeSpanUsage()
        {
            TimeSpan fiveSeconds = TimeSpan.FromSeconds(5);

            TimeSpan halfAMin = TimeSpan.FromMinutes(.5);

            Assert.AreEqual(TimeSpan.FromMilliseconds(35000), fiveSeconds + halfAMin);

            // it is the milliseconds component so 0. 5 seconds, 0 milliseconds
            Assert.AreNotEqual(5000, fiveSeconds.Milliseconds);

            // property that expresses whole value in totalX
            Assert.AreEqual(5000d, fiveSeconds.TotalMilliseconds);
            Assert.AreEqual(0.5d, halfAMin.TotalMinutes);
        }

        [Test]
        public void DateTimeUsage()
        {
            // Had to fiddle with my time hours to get first test to pass
            // Never use DateTime

            DateTime jonsTime = new DateTime(2011, 4, 1, 21, 24, 0, DateTimeKind.Local);
            DateTime RobsTime = new DateTime(2011, 4, 1, 10, 24, 0, DateTimeKind.Local);
            DateTime utcTime = new DateTime(2011, 4, 1, 20, 24, 0, DateTimeKind.Utc);
            DateTime myTime = new DateTime(2011, 4, 1, 16, 24, 0, DateTimeKind.Local);
            DateTime myTimeUnspecified = new DateTime(2011, 4, 1, 16, 24, 0, DateTimeKind.Unspecified);

            Assert.AreEqual(utcTime, myTime.ToUniversalTime());
            Assert.AreEqual(utcTime, utcTime.ToUniversalTime());
            Assert.AreEqual(utcTime, myTimeUnspecified.ToUniversalTime());
        }

        [Test]
        public void DateTimeOffsetUsage()
        {
            DateTimeOffset jonsTime = new DateTimeOffset(2011, 4, 1, 21, 24, 0,
                                                         TimeSpan.FromHours(1));

            DateTimeOffset robsTime = new DateTimeOffset(2011, 4, 1, 10, 24, 0,
                                                         TimeSpan.FromHours(-10));

            Assert.AreEqual(jonsTime, robsTime);
        }

        [Test]
        public void TimeZoneInfoUsage()
        {
            TimeZoneInfo zone = TimeZoneInfo.Local;

            Assert.AreEqual(TimeSpan.FromHours(-5),
                            zone.GetUtcOffset(new DateTime(2011, 3, 13, 0, 0, 0)));

            Assert.AreEqual(TimeSpan.FromHours(-4),
                            zone.GetUtcOffset(new DateTime(2011, 3, 13, 3, 0, 0)));
        }
    }
}
