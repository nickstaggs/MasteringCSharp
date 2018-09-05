using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class CollectionsTest
    {

        [Test]
        public void ListBasics()
        {
            List<string> names = new List<string>();

            names.Add("fred");

            // Indexing in lists is like a method call to GetItem(0)
            Assert.AreEqual("fred", names[0]);

            Assert.AreEqual(1, names.Count);

            names.Add("jill");

            Assert.AreEqual(2, names.Count);

            names.RemoveAt(0);

            Assert.AreEqual(1, names.Count);
            Assert.AreEqual("jill", names[0]);
        }

        [Test]
        public void DictionaryBasics()
        {
            var map = new Dictionary<string, int>();

            map.Add("foo", 10);
            map["bar"] = 30;

            foreach (var entry in map)
            {
                Console.WriteLine("{0} : {1}", entry.Key, entry.Value);
            }

            int value;
            bool keyFound = map.TryGetValue("blah", out value);

            Assert.IsFalse(keyFound);
            // value gets default value when key does not exist in dictionary
            Assert.AreEqual(0, value);

            Assert.AreEqual(2, map.Count);
        }
    }
}
