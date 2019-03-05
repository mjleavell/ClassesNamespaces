using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Heads
{
    // abstract doesnt allow users to instantiate the class
    // it is solely meant to be inherited...basically a template
    abstract class Head
    {
        public HairLength HairLength { get; set; }
        public Colors Color { get; set; }
        public string EarSize { get; set; }
    }
}
