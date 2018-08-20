using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{   
    [TestFixture]
    class SimpleTypes
    {

        [Test]
        public void DisplayIntValues()
        {
            /*
             * int = System.Int32
             * uint = System.UInt32
             * 
             * long = System.Int64
             * ulong = System.UInt64
             * 
             * byte = System.Byte (8 Bits)
             * sbyte = System.SByte (8 bits)
             * 
             * short = System.Int16
             * ushort = System.UInt16
             * 
             * ---- outside clr -----
             * 
             * BigInteger new to .NET 4.0
             *      -grows as it needs to only limited by available memory
            */

            int x = 10;
            int y = x;
            x = x++ + ++x; // x = 22

            Console.WriteLine(x);
        }

        [Test]
        public void DisplayFloatingPointValues()
        {
            // float = System.Single (32 bits) f 
            // double = System.Double (64 bits) d
            // decimal = System.Decimal (128 bits) m

            // 3 parts to floating point
            // 1) sign: 0 (positive/zero or 1 (negative)
            // 2) exponent or power
            // 3) mantissa (an integer)

            Assert.AreEqual(0x64, 100);

            float v1 = 0.2f;
            double v2 = 0.2; // or 0.2d
            decimal v3 = 0.3m;

            double x = 0.1;
            x += 0.000001;
            x += 0.000001;
            x += 0.000001;
            x += 0.000001;
            x += 0.000001;
            Assert.AreNotEqual(0.100005, x); // weird, right?

            decimal y = 0.1m;
            y += 0.000001m;
            y += 0.000001m;
            y += 0.000001m;
            y += 0.000001m;
            y += 0.000001m;
            Assert.AreEqual(0.100005m, y);

            // Rule of thumb for when to use decimal vs double
            // Natural, not completely accurate double/float are fine
            // Man made, very accurate use decimal
        }
    }
}
