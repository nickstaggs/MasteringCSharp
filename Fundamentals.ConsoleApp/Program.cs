using System;
using System.Threading;
using System.Text.RegularExpressions;

namespace Fundamentals.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "hello";
            string y = x.Substring(startIndex: 1, length: 3);
            string z = x.Substring(startIndex: 2);

            int firstEllIndex = x.IndexOf('l');
            int secondEllIndex = x.IndexOf('l', firstEllIndex+1);
            int thirdEllIndex = x.IndexOf('l', secondEllIndex+1);

            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(firstEllIndex);
            Console.WriteLine(secondEllIndex);
            Console.WriteLine(thirdEllIndex);

            SplitExamples();

            RegexExample();

            Thread.Sleep(3000);
        }

        private static void SplitExamples()
        {
            string x = "Jon Skeet-Webb";

            string[] bits = x.Split('-', ' ', '|');

            foreach (string word in bits)
            {
                Console.WriteLine(word);
            }
        }

        private static void RegexExample()
        {
            Regex pattern = new Regex(@"\d");
            string text = "Nick0Staggs1Jon2Skeet3someone";
            string[] words = pattern.Split(text);

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            string sample = "hello, world!";
            Regex notVowelsPattern = new Regex("[^aeiou,! ]");
            string vowels = notVowelsPattern.Replace(sample, "*");
            Console.WriteLine(vowels);
        }
    }
}
