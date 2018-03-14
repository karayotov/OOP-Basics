using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester : Unit
{
    private const int MIN_VALUE = 0;
    private const int MAX_VALUE = 20_000;

    private double oreoutput;
    private double energyReqirement;

    public double OreOutput
    {
        get { return oreoutput; }
        private set
        {
            if (value < MIN_VALUE)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's OreOutput"); 
            }
            oreoutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return energyReqirement; }
        private set
        {
            if (value < MIN_VALUE || value > MAX_VALUE)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            energyReqirement = value;
        }
    }

    protected Harvester(string id, double oreoutput, double energyReqirement): base(id)
    {
        this.OreOutput = oreoutput;
        this.EnergyRequirement = energyReqirement;
    }

    public override string ToString()
    {
        return $"{Type} Harvester - {Id}" + Environment.NewLine +
            $"Ore Output: {OreOutput}" + Environment.NewLine +
            $"Energy Requirement: { EnergyRequirement}";
    }
}
