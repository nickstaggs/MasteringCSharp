using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using MasteringCSharp;

namespace Fundamentals.Tests
{
    [TestFixture]
    class FakeEventRaiserTest
    {

        private void ReportToConsole(string text)
        {
            Console.WriteLine("Called: {0}", text);
        }

        [Test]
        public void RaiseEvents()
        {
            FakeEventHandler handler = ReportToConsole;

            FakeEventRaiser raiser = new FakeEventRaiser();

            raiser.DoSomething("Not subscribed");

            raiser.AddHandler(handler);
            raiser.DoSomething("Subscribed");

            raiser.AddHandler(handler);
            raiser.DoSomething("Subscribed twice!");

            raiser.RemoveHandler(handler);
            raiser.RemoveHandler(handler);
            raiser.DoSomething("Unsubscribed");
        }
    }
}
