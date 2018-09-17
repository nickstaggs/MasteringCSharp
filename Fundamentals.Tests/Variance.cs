using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{

    public interface IEdible { }
    public abstract class Fruit : IEdible { }
    public class Apple : Fruit { }
    public class Banana : Fruit {
        public override string ToString()
        {
            return "banana";
        }
    }

    public class Pizza : IEdible { }


    public abstract class Shape
    {
        public abstract double Area { get;  }
    }
    public class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area => Math.PI * radius * radius;
    }
    public class Square : Shape
    {
        private readonly double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double Area => sideLength * sideLength;
    }

    public class AreaComparer : IComparer<Shape>
    {
        public int Compare(Shape x, Shape y)
        {
            return x.Area.CompareTo(y.Area);
        }
    }


    // Covariance 
    public interface IFoo<out T>
    {
        
        T giveMeFoo();
    }

    // Contravariance
    public interface IBar<in T>
    {
        void AddABar(T input);
    }

    public delegate void DoSomethingWithT<in T>(T input);
    public delegate T GiveMeAnInstanceOfT<out T>();

    delegate void Action<in T>(T input);
    delegate T Func<out T>();

    [TestFixture]
    public class Variance
    {

        [Test]
        public void Demo()
        {
            List<Banana> bananas = new List<Banana>();
            bananas.Add(new Banana());

            IEnumerable<Fruit> edibles = bananas;

            EatAll(edibles);

            List<Circle> shapes = new List<Circle>
            {
                new Circle(10),
                new Circle(5),
                new Circle(20)
            };

            shapes.Sort(new AreaComparer());

            Random random = new Random();

            Func<int> die = () => random.Next(6) + 1;
            // Only reference type type arguments can viewed covariantly or contravariantly
            // hence the need for a wrapper not just: Func<object> objectDie = die; 
            Func<object> wrapper = () => die();
        }

        public void EatAll(IEnumerable<IEdible> edibles)
        {
            Console.WriteLine(edibles.GetType());

            foreach (var edible in edibles)
            {
                Console.WriteLine("Ate a " + edible);
            }
        }
    }
}
