using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class StringTest
    {

        [Test]
        public void LengthTest()
        {
            string x = "hello";

            Assert.AreEqual(5, x.Length);
        }

        [Test]
        public void NullTermination()
        {
            char[] nullTerminated = { 'h', 'e', 'l', 'l', 'o', '\0' };

            Console.WriteLine(nullTerminated);
        }
    }
}
