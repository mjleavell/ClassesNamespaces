using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Torsos
{
    class SkeletonTorso : Torso
    {
        public SkeletonTorso(int numberOfArms)
            : base(Sex.Shrug,Colors.Bone,"bony")
        {
        }

        public void Rattle()
        {
            Console.WriteLine("Rattle Rattle...");
            Wave();
        }
    }
}
