using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCSharp
{
    public delegate void Int32Action(int value);

    // delegate is like vvv
    public interface IInt32Action
    {
        void DoIt(int value);
    }

    public class Delegates : IInt32Action
    {
        void IInt32Action.DoIt(int value)
        {
            Console.WriteLine("Interface implementation: {0}", value);
        }

        public void RandomRob(int value)
        {
            Console.WriteLine("Delegate Implementation: {0}", value);
        }

        public static void StaticRob1(int value)
        {
            Console.WriteLine("Static method 1: {0}", value);
        }
        public static void StaticRob2(int value)
        {
            Console.WriteLine("Static method 2: {0}", value);
        }
    }
}
