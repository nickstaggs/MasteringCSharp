using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCSharp
{
    public class Chainsaw : IControllable
    {
        void IControllable.Start()
        {
            Console.WriteLine("Brrrm Brrrm");
        }

        void IControllable.Stop()
        {
            Console.WriteLine("Thudder der der");
        }
    }
}
