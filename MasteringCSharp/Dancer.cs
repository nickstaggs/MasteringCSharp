using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCSharp
{
    public abstract class Dancer : IControllable
    {
        public virtual void Dance()
        {
            Console.WriteLine("Dance Dance");
        }
        public void Start()
        {

            Console.WriteLine("Starting Dancing");
            Dance();
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Dancing");
        }
    }
}
