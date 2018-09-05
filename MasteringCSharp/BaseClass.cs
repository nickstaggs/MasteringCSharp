using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCSharp
{
    public class BaseClass
    {
        private readonly string name;

        public string Name { get { return name;  } }

        public BaseClass() : this("default") { }

        public BaseClass(string name)
        {
            this.name = name;
        }

        public virtual int CalculateResult(int x)
        {
            return x * 2;
        }

        public int TrebleInput(int x)
        {
            return x * 3;
        }
    }
}
