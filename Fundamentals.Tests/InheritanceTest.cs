using NUnit.Framework;
using MasteringCSharp;

namespace Fundamentals.Tests
{
    [TestFixture]
    class InheritanceTest
    {

        [Test]
        public void CalculateResultDoublesInput()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(2, test.CalculateResult(1));
        }

        [Test]
        public void TrebleInputTriplesInput()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(3, test.TrebleInput(1));
        }

        [Test]
        public void NameDefaultsToDefault()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual("default", test.Name);
        }

        [Test]
        public void SpecificNameResultsInSpecificName()
        {
            BaseClass test = new BaseClass("poop");
            Assert.AreEqual("poop", test.Name);
        }

        [Test]
        public void DerivedClassDefaultName()
        {
            BaseClass dTest = new DerivedClass();
            Assert.AreEqual("derived default", dTest.Name);

            BaseClass dTest2 = new DerivedClass("nick");
            Assert.AreEqual("derived nick", dTest2.Name);
        }
    }
}
