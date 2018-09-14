using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Fundamentals.Tests
{

    [TestFixture]
    class LinqTest
    {

        [Test]
        public void ScratchPad()
        {
            List<String> names = new List<string>
            {
                "Rob, Friend",
                "Holly, Family",
                "This isn't a name",
                "Malcolm, Colleague",
                "Tom, Family"
            };

            Regex pattern = new Regex("(.*), (.*)");


            // query expression: whole thing after =
            // range variable: line
            // match another range variable due to let
            var query = from line in names
                        let match = pattern.Match(line)
                        where match.Success
                        select new
                        {
                            Name = match.Groups[1].Value,
                            Relationship = match.Groups[2].Value
                        } into association // match and line go out of scope due to into clause
                        group association.Name by association.Relationship;

            foreach (var group in query)
            {
                Console.WriteLine("Relationship: {0}", group.Key);

                foreach (var name in group)
                {
                    Console.WriteLine(" {0}", name);
                }
            }
        }
    }
}
