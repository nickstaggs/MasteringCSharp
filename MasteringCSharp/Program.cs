using System;
using System.Collections.Generic;
using System.Threading;

namespace MasteringCSharp
{
    class Program
    {
        class Fruit {}
        class Apple : Fruit { }
        class Banana : Fruit { }

        interface IFooCovariance<out T>
        {
            T GiveMeAnInstanceOfT();
        }

        interface IFooContravariance<in T>
        {
            void TakeAnInstanceOfT(T instance);
        }

        static void Main(string[] args)
        {
            // Covariance and Contravariance

            IFooContravariance<Fruit> fruit = null;
            IFooContravariance<Apple> apple = fruit;

            IFooCovariance<Apple> apple2 = null;
            List<IFooCovariance<Fruit>> fruit2 = new List<IFooCovariance<Fruit>>();


            // dynamic
            dynamic x = "hello";
            Console.WriteLine(x.Length);
            x = new int[] { 10, 20, 30 };
            Console.WriteLine(x.Length);

            Thread.Sleep(2000);
        }

        static void foo(string x)
        {
            Console.WriteLine(x);
        }
    }
}
