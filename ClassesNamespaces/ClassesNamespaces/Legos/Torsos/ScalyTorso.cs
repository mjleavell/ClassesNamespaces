using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Torsos
{
    class ScalyTorso : Torso
    {
        public ScalyTorso()
            : base(4,Sex.Other,Colors.Red,"hard as a rock")
        {

        }

        public override void Wave()
        {
            // string literal bc was treating \0/ as an escape key
            Console.WriteLine(@"Fragile waving \0/");
        }
    }
}
