using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MasteringCSharp;

namespace Fundamentals.Tests
{

    [TestFixture]
    class LonghandEventRaiserTest
    {

        private void ReportToConsole(object sender, EventArgs e)
        {
            Console.WriteLine("ReportToConsole was called");
        }

        [Test]
        public void RaiseEvents()
        {
            ClickHandler handler = ReportToConsole;

            var raiser = new LonghandEventRaiser();

            raiser.OnClick();

            raiser.Click += handler;
            raiser.OnClick();

            raiser.Click += handler;
            raiser.OnClick();

            raiser.Click -= handler;
            raiser.Click -= handler;
            raiser.OnClick();
        }
    }
}
