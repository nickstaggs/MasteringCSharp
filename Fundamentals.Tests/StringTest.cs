using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class StringTest
    {

        [Test]
        public void LengthTest()
        {
            string x = "hello";

            Assert.AreEqual(5, x.Length);
        }

        [Test]
        public void NullTermination()
        {
            char[] nullTerminated = { 'h', 'e', 'l', 'l', 'o', '\0' };

            Console.WriteLine(nullTerminated);
        }

        [Test]
        public void AssignmentAndReplacement()
        {
            string x = "hello";
            string y = x;

            x = x.Replace('h', 'j');

            Assert.AreEqual("jello", x);
            Assert.AreEqual("hello", y);
        }

        [Test]
        public void DifferentEqualObjects()
        {
            string x = "hello";
            x = x.Replace('h', 'j');

            object o1 = x;
            object o2 = "jello";

            Assert.AreNotSame(o1, o2);
            Assert.IsFalse(o1 == o2);
            Assert.IsTrue(o1.Equals(o2));
        }

        [Test]
        public void DifferentEqualStrings()
        {
            string x = "hello";
            x = x.Replace('h', 'j');

            string s1 = x;
            string s2 = "jello";

            Assert.AreNotSame(s1, s2);
            Assert.IsTrue(s1 == s2);
            Assert.IsTrue(s1.Equals(s2));
            Assert.IsTrue(object.Equals(s1, s2));
        }

        [Test]
        public void InterningOfConstants()
        {
            string x = "hello";
            string y = "hello";
            Assert.AreSame(x, y);
        }

        [Test]
        public void InterningOfConcatenation()
        {
            string x = "hello";
            string y = "he" + "llo";

            Assert.AreSame(x, y);
        }

        [Test]
        public void NonInterningOfNonConstants()
        {
            string he = "he";
            string x = "hello";
            string y = he + "llo";

            Assert.AreNotSame(x, y);
            Assert.AreEqual(x, y);
        }

        [Test]
        public void BadConcatenation()
        {
            string simple = new string('x', 100000);

            string bad = "";

            for (int i = 0; i < 100000; i++)
            {
                bad = bad + "x";
            }

            Assert.AreEqual(simple, bad);
        }

        [Test]
        public void GoodConcatenation()
        {
            StringBuilder builder = new StringBuilder();
            string simple = new string('x', 100000);

            for (int i = 0; i < 100000; i++)
            {
                builder.Append("x");
            }

            Assert.AreNotEqual(simple, builder);

            string good = builder.ToString();

            Assert.AreEqual(simple, good);
        }

        [Test]
        public void BadUseOfStringBuilder()
        {
            string x = "x";
            string y = "y";

            // Want "x y" or x + " " + y
            StringBuilder builder = new StringBuilder();

            builder.Append(x);
            builder.Append(" ");
            builder.Append(y);

            string result = builder.ToString();

            Assert.AreEqual("x y", result);
        }

        [Test]
        public void GoodUseOfConcatenation()
        {
            string x = "x";
            string y = "y";

            string result = x + " " + y;

            Assert.AreEqual("x y", result);
        }

        [Test]
        public void CompilerTranslationOfConcatenation()
        {
            string x = "x";
            string y = "y";

            string result = String.Concat(x, " ", y);

            Assert.AreEqual("x y", result);
        }

        [Test]
        public void StringJoin()
        {
            string[] vals = { "x", " ", "y" };

            string commaSeparated = string.Join(",", vals);

            Assert.AreEqual("x, ,y", commaSeparated);
        }

        [Test]
        public void StringFormat()
        {
            string x = "x";
            string y = "y";

            string result = String.Format("{0} {1}", x, y);

            Assert.AreEqual("x y", result);
        }

        [Test] 
        public void StringFormat2()
        {
            int val = 100;
            string y = "y";

            string result = string.Format("val={0} y={1}", val, y);

            Assert.AreEqual("val=100 y=y", result); //Locale dependent
        }

        [Test]
        public void StringFormat3()
        {
            int val = 100;
            string y = "y";

            string result = string.Format("val=0x{0:x} y={1}", val, y);

            Assert.AreEqual("val=0x64 y=y", result); //Locale dependent
        }

        [Test]
        public void StringFormat5()
        {
            decimal price = 10.50432432m;

            string result = string.Format("price={0:c}", price);
            Assert.AreEqual("price=$10.50", result); //Locale dependent in the UK (poundsign weird L)10.50, culture of thread
        }
    }
}
