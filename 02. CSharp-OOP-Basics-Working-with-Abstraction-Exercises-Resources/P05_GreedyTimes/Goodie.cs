using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GreedyTimes
{
    class Goodie
    {
        string name;
        long amount;

        public string Name { get => name; set => name = value; }
        public long Amount { get => amount; set => amount = value; }

        public Goodie(string name, long amount)
        {
            Name = name;
            Amount = amount;
        }

    }
}
