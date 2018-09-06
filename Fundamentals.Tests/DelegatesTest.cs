using System;
using System.Collections.Generic;
using System.Text;
using MasteringCSharp;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class DelegatesTest
    {

        [Test]
        public void SingleMethodInterface()
        {
            IInt32Action action = new Delegates();
            action.DoIt(10);


        }

        [Test]
        public void SimpleDelegateFromMethod()
        {
            Delegates target = new Delegates();
            Int32Action action = new Int32Action(target.RandomRob);

            action.Invoke(10);
        }

        [Test]
        public void DelegateFromStaticMethod()
        {
            Int32Action action = new Int32Action(Delegates.StaticRob1);

            action.Invoke(8);
        }

        [Test]
        public void Multicast()
        {
            Int32Action action1 = new Int32Action(Delegates.StaticRob1);
            Int32Action action2 = new Int32Action(Delegates.StaticRob2);

            Int32Action action3 = action1 + action2;

            action3(20);
        }
    }
}
