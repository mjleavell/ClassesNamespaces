﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Legs
{
    class OrangeLegs : LegsBase
    {
        public OrangeLegs(Length legLength)
            : base(legLength, Colors.Orange)
        {
            Hairy = true;
            CanBend = true;
        }

        public override void Jump()
        {
            Console.WriteLine("Orange legs lose control and flail around");
        }


    }
}
