using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Torsos
{
    abstract class Torso
    {
        private Sex shrug;
        private Colors bone;

        public int NumberOfArms { get; protected set; }
        public string FitnessOfAbdomen { get; protected set; }
        public Colors Color { get; protected set; }
        public Sex Sex { get; protected set; }

        protected Torso(int numberOfArms, Sex sex, Colors color, string fitnessOfAbdomen)
        {
            NumberOfArms = numberOfArms;
            Sex = sex;
            Color = color;
            FitnessOfAbdomen = fitnessOfAbdomen;
        }

        protected Torso(Sex shrug, Colors bone, string v)
        {
            this.shrug = shrug;
            this.bone = bone;
        }

        public virtual void Wave()
        {
            Console.WriteLine("Waves hello 0/");
        }
    }

    internal enum Sex
    {
        Male,
        Female,
        Other,
        Shrug
    }
}
