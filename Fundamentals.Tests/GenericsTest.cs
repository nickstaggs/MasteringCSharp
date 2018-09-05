using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class GenericsTest
    {

        [Test]
        public void GenericBasics()
        {
            Generic<string> genericString = new Generic<string>("hi");
            Assert.AreEqual("hi", genericString.GenericProperty);

            Generic<int> genericInt = new Generic<int>(100);
            Assert.AreEqual(100, genericInt.GenericProperty);
        }

        [Test]
        public void GenericVarBasics()
        {
            var genericString = new Generic<string>("hi");
            Assert.AreEqual("hi", genericString.GenericProperty);

            var genericInt = new Generic<int>(100);
            Assert.AreEqual(100, genericInt.GenericProperty);
        }


        public class Generic<T>
        {
            public T GenericProperty { get; set; }

            public Generic(T generic)
            {
                GenericProperty = generic;
            }

        }
    }
}
