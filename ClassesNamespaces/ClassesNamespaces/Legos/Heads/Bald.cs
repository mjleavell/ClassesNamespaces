﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces.Legos.Heads
{
    class Bald : Head
    {
        // ------------ PROPERTIES ------------
        public int ShineLevel { get; set; }
        public bool IsToupe { get; set; }

        // ------------ FIELDS ------------

        // ------------ CONSTRUCTOR ------------

        // ------------ METHODS ------------
        public void Cut(HairLength newLength)
        {
            HairLength = HairLength.CompletelyBald;
        }

        public string Talk()
        {
            return "I pity the fool!";
        }
    }

    internal enum Colors
    {
        Yellow,
        Red,
        Freckles,
        Tan
    }

    internal enum HairLength
    {
        CompletelyBald,
        Stubble,
        Short,
        Medium,
        Long
    }
}