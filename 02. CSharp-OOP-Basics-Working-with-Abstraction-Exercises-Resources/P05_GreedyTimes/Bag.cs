using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GreedyTimes
{
    class Bag
    {
        long capacity;
        List<Goodie> goodies;

        public long Capacity { get => capacity; set => capacity = value; }
        internal List<Goodie> Goodies { get => goodies; set => goodies = value; }

        public Bag(long capacity)
        {
            Capacity = capacity;
        }
        public Bag(long capacity, List<Goodie> goodies):this(capacity)
        {
            Goodies = goodies;
        }

        //public bool SumBagAmount()

    }
}