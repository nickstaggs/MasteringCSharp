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

            var query1 = names.Select(line => new { line, match = pattern.Match(line) })
                           .Where(z => z.match.Success)
                           .Select(z => new
                           {
                               Name = z.match.Groups[1].Value,
                               Relationship = z.match.Groups[2].Value
                           })
                           .GroupBy(association => association.Relationship,
                                    association => association.Name);

            // Query expression form
            // query expression: whole thing after =
            // range variable: line
            // match another range variable due to let
            var query2 = from line in names
                        let match = pattern.Match(line)
                        where match.Success
                        select new
                        {
                            Name = match.Groups[1].Value,
                            Relationship = match.Groups[2].Value
                        } into association // match and line go out of scope due to into clause
                        group association.Name by association.Relationship;

            var query3 = from line in names
                         where line.Length < 15
                         select line;

            var query32 = names.Where(line => line.Length < 15);

            foreach (var group in query1)
            {
                Console.WriteLine("Relationship: {0}", group.Key);

                foreach (var name in group)
                {
                    Console.WriteLine(" {0}", name);
                }
            }

            foreach (var line in query32)
            {
                Console.WriteLine(line);
            }
        }
    }
}
