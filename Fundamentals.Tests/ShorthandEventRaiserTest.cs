using MasteringCSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Tests
{
    [TestFixture]
    class ShorthandEventRaiserTest
    {

        private void ReportToConsole(object sender, EventArgs e)
        {
            Console.WriteLine("ReportToConsole was called");
        }

        [Test]
        public void RaiseEvents()
        {
            ClickHandler handler = ReportToConsole;

            var raiser = new ShorthandEventRaiser();

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
