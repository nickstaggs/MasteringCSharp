using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Tests
{
    [TestFixture]
    class AnonymousTypes
    {

        private void DoSomething<T1>(T1 value)
        {
            Console.WriteLine(value);
        }

        [Test]
        public void Demo()
        {
            var person = new { FirstName = "Jon", LastName = "Skeet" };

            var people = new[] {
                person,
                new { FirstName = "Rob", LastName = "Conery"}
            };

            var weirdPerson = new { FirstName = 10, LastName = 20 };

            var weirdPeople = new { weirdPerson, people };

            DoSomething(weirdPeople);
        }
    }
}
