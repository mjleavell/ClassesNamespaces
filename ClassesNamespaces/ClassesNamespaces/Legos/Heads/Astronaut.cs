using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Heads
{
    class Astronaut : Head
    {
        public List<string> Accessories { get; set; }

        public string Talk()
        {
            return $"Houston, we have a problem. I have {HairLength} " + 
                $"long hair and I'm {Color} and my ears are {EarSize}";
        }
    }
}
