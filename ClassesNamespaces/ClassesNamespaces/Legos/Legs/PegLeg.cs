using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Legs
{
    class PegLeg : LegsBase
    {
        // I  only need somoene telling me the leg length for peg legs because i know all of 
        // my leg lenghts are tan
        public PegLeg(Length legLength) : base(legLength,Colors.Tan)
        {

        }

        public override void Jump()
        {
            Console.WriteLine($"The {(Hairy ? "hairy" : "")} peg legs dont jump");
        }
    }
}
