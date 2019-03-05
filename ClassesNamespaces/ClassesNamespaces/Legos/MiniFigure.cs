using ClassesNamespaces.Legos.Heads;
using ClassesNamespaces.Legos.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos
{
    class MiniFigure
    {
        public Head Head { get; set; }
        public Torso Body { get; set; }
        // Legs

        // Constructors --- what does this file have to have in order to create the minifigure
        // anything that is a head or is a torso can be passed in
        public MiniFigure(Head head, Torso body)
        {
            Head = head;
            Body = body;
        }

        // dont have anything that is inherited (Body.Crunch) bc we only wanted base level (things defined on base0
        public void Greet()
        {
            Body.Wave();
            Head.Talk();
        }
    }
}
