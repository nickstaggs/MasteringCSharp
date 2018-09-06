using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCSharp
{
    public class StartAndStopper
    {

        public void StartAndStop(IControllable controllable)
        {
            controllable.Start();
            controllable.Stop();
        }
    }
}
