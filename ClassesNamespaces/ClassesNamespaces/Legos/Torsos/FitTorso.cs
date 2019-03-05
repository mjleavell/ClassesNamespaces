using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Torsos
{
    class FitTorso : Torso
    {
        public FitTorso(int numberOfArms, Sex sex, Colors color)
            : base(numberOfArms, sex, color, "OMG, fit AF!")
        {
        }

        public void Crunch(int howManyCrunches)
        {
            Console.WriteLine($"I just did {howManyCrunches}, bro bc CROSSFIT");
        }

        public override void Wave()
        {
            base.Wave();
            Console.WriteLine("(ツ)_/¯ ");
        }
    }
}
