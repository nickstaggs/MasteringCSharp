using System;
using System.Collections.Generic;
using System.Text;
using MasteringCSharp;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class ExtensionTests
    {
        
        [Test]
        public void InvokeReverse()
        {
            string reversed = "hello".Reverse();
            Assert.AreEqual("olleh", reversed);
        }

        [Test]
        public void InvokeGreaterThan5()
        {
            Assert.IsTrue("This is a string longer than 5 characters".IsGreaterThan5());
        }
    }
}
