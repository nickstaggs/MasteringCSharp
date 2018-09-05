using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCSharp
{
    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base("derived default") { }

        public DerivedClass(string localName)
            : base("derived " + localName) { }
    }
}
