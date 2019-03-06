using System;
using System.Collections.Generic;
using System.Text;
using ClassesNamespaces.Legos.Legs;
using ClassesNamespaces.Legos.Heads;
using ClassesNamespaces.Legos.Torsos;

namespace ClassesNamespaces.Legos
{
    class MiniFigure
    {
        public string Name { get; set; }
        public Head Head { get; set; }
        public Torso Body { get; set; }
        public LegsBase Legs { get; set; }

        // Constructors --- what does this file have to have in order to create the minifigure
        // anything that is a head or is a torso can be passed in
        public MiniFigure(string name, Head head, Torso body, LegsBase legs)
        {
            Name = name;
            Head = head;
            Body = body;
            Legs = legs;
        }

        // dont have anything that is inherited (Body.Crunch) bc we only wanted base level (things defined on base0
        public void Greet()
        {
            Body.Wave();
            Head.Talk();
            Legs.Walk();
        }
    }
}
