using System;
using System.Collections.Generic;
using System.Text;

namespace favoritethings
{
    class pizza
    {
        public string Crust { get; set; }
        public string Style { get; set; }
        private int Slices = 8;

        public void EatSlices(string numSlices)
        {
            if (Int32.Parse(numSlices) <= Slices)
            {
                Slices -= Int32.Parse(numSlices);
                Console.WriteLine($"You ate {numSlices} slices of pizza.  There are {Slices} slices of pizza left");
            } else
            {
                throw new Exception($"You can't do that. There are {Slices} slices of pizza left");
            }
        }
        
        public void Inspect()
        {
            Console.WriteLine($"This is a {Style} style pizza with a {Crust} crust.  It has {Slices} remaining");
        }
    }
}
