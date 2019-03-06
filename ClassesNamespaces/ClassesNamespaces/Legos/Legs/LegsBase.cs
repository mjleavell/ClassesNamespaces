using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Legs
{
    abstract class LegsBase
    {
        public bool Hairy { get; set; }
        public Colors Color { get; set; }
        public bool CanBend { get; set; }
        public Length Length { get; set; }

        public LegsBase(Length length, Colors color)
        {
            // setting the properties
            Length = length;
            Color = color;
        }

        public virtual void Jump()
        {
            Console.WriteLine("WEEEEEE");
        }

        public void Kick(MiniFigure personToKick)
        {
            // GetType() will give you the type of thing that you actually are

            Console.WriteLine($"{personToKick.Name} just got kicked {GetType().Name}. Ha Ha Ha.");
        }

        public void Walk()
        {
            Console.WriteLine($" {GetType().Name} Took a few steps");
        }
    }

    enum Length
    {
        Short,
        Medium,
        Long,
        SuperLong
    }
}
