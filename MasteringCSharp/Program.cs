using System;
using System.Threading;

namespace MasteringCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
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
