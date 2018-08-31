using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class ArrayTest
    {
        [Test]
        public void ArrayValuesAreReferenceTypes()
        {
            int[] array = new int[10];

            array[0] = 5;
            AddOne(ref array[0]);

            Assert.AreEqual(array[0], 6);

            AddOneTo0thElement(array);

            Assert.AreEqual(array[0], 7);
        }

        public void AddOne(ref int val)
        {
            val++;
        }

        public void AddOneTo0thElement(int[] arr)
        {
            arr[0]++;
        }
    }
}
