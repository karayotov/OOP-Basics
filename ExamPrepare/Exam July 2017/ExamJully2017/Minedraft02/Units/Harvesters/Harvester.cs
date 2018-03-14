using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester : Unit
{
    private const int MIN_VALUE = 0;

    private const int MAX_VALUE = 20_000;

    private double oreOutput;

    private double energyRequirement;


    public Harvester(string id) : base(id)
    {
    }

    public double OreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value < MIN_VALUE)
            {
                throw new ArgumentException($"");
            }
            oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        protected set
        {
            if (value < MIN_VALUE || value > MAX_VALUE)
            {
                throw new ArgumentException($"");
            }
            energyRequirement = value;
        }
    }
}
