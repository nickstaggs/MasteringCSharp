using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    public delegate void Int32ActionTest(int value);

    public delegate void GenericAction<T>(T value);

    [TestFixture]
    public class AnonymousFunctionsTest
    {

        private void MethodTakingString(string value)
        {
            Console.WriteLine(value);
        }

        [Test]
        public void MethodGroupConversion()
        {
            GenericAction<string> action = MethodTakingString;
            action("Hi!");
        }

        private int SquareInt32(int x)
        {
            return x * x;
        }

        private double SquareRootInt32(int x)
        {
            return Math.Sqrt(x);
        }

        [Test]
        public void ListConversion()
        {
            List<int> original = new List<int> { 1, 2, 3 };
            List<int> squares = original.ConvertAll(SquareInt32);

            foreach (int val in squares)
            {
                Console.WriteLine(val);
            }

            List<double> squareRoots = original.ConvertAll(SquareRootInt32);

            foreach (double val in squareRoots)
            {
                Console.WriteLine(val);
            }
        }

        [Test]
        public void AnonymousMethodsV1()
        {
            Converter<int, double> converter = delegate (int x)
            {
                return Math.Sqrt(x);
            };

            List<int> original = new List<int> { 1, 2, 3 };

            List<double> squareRoots = original.ConvertAll(converter);

            foreach (double val in squareRoots)
            {
                Console.WriteLine(val);
            }
        }

        [Test]
        public void AnonymousMethodsV2()
        {
            List<int> original = new List<int> { 1, 2, 3 };

            List<double> squareRoots = original.ConvertAll(delegate (int x)
            {
                return Math.Sqrt(x);
            });

            foreach (double val in squareRoots)
            {
                Console.WriteLine(val);
            }
        }
        [Test]
        public void AnonymousMethodsV3()
        {
            List<int> original = new List<int> { 1, 2, 3 };

            List<double> squareRoots = original.ConvertAll(x => Math.Sqrt(x));

            foreach (double val in squareRoots)
            {
                Console.WriteLine(val);
            }
        }

        [Test]
        public void ClosureAnonymousMethods()
        {
            double power = 0.5;
            int calls = 0;

            Converter<int, double> converter = delegate (int x)
            {
                calls++;
                return Math.Pow(x, power);
            };

            List<int> original = new List<int> { 1, 2, 3 };

            List<double> squareRoots = original.ConvertAll(converter);

            foreach (double val in squareRoots)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("Total calls: {0}", calls);

            power = 2;

            List<double> squares = original.ConvertAll(converter);

            foreach (int val in squares)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("Total calls: {0}", calls);
        }

        [Test]
        public void ClosureLambda()
        {

            double power = 0.5;

            Converter<int, double> converter = x => Math.Pow(x, power);


            List<int> original = new List<int> { 1, 2, 3 };

            List<double> squareRoots = original.ConvertAll(converter);

            foreach (double val in squareRoots)
            {
                Console.WriteLine(val);
            }

            power = 2;

            List<double> squares = original.ConvertAll(converter);

            foreach (int val in squares)
            {
                Console.WriteLine(val);
            }
        }

        [Test]
        public void ExpressionTrees()
        {
            System.Linq.Expressions.Expression<Converter<int, double>> converter = x => Math.Pow(x, 0.5);

            // representing code as data
            Console.WriteLine(converter);

            Converter<int, double> compiles = converter.Compile();
        }

        [Test]
        public void DangerWillRobinson()
        {
            List<string> words = new List<string> { "Danger", "Will", "Robinson"};
            List<Action> actions = new List<Action>();

            foreach(var word in words)
            {
                actions.Add(() => Console.WriteLine(word));
            }

            foreach(var action in actions)
            {
                action();
            }
        
        }
    }
}
