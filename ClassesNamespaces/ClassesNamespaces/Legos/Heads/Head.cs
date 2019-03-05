using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Heads
{
    // abstract doesnt allow users to instantiate the class
    // it is solely meant to be inherited...basically a template
    abstract class Head
    {
        public HairLength HairLength { get; protected set; }
        public Colors Color { get; protected set; }
        public string EarSize { get; protected set; }

        // virtual and overrides act as a pair
        public virtual string Talk()
        {
            return "I'm a talking head";
        }

        public string Chew()
        {
            return "I'm chewing my food becuase I'm hungry";
        }
    }
}
