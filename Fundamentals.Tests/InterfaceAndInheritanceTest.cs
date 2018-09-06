using NUnit.Framework;
using MasteringCSharp;

namespace Fundamentals.Tests
{   
    [TestFixture]
    class InterfaceAndInheritanceTest
    {

        [Test]
        public void ControllablesStopAndStart()
        {
            Dancer dancer = new TapDancer();

            Chainsaw chainsaw = new Chainsaw();

            StartAndStopper test = new StartAndStopper();

            test.StartAndStop(dancer);
            test.StartAndStop(chainsaw);
        }
    }
}
