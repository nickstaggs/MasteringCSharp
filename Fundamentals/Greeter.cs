using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals
{
    public class Greeter
    {

        public string Speaker { get; private  set; }

        public Greeter(string speaker)
        {
            this.Speaker = speaker;
        }

        public string SayHello(string recipient)
        {   
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient");
            }

            if (Speaker == null)
            {
                return "Hello " + recipient;
            }

            return "Hello " + recipient + " from " + Speaker;
        }
    }
}
