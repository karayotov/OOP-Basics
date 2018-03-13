using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester
{
    private const int MIN_VALUE = 0;
    private const int MAX_VALUE = 20_000;


    private string id;
    private double oreoutput;
    private double energyReqirement;

    public string Id
    {
        get { return id; }
        protected set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid Harvester Id value!");
            }
            id = value;
        }
    }

    public double OreOutput
    {
        get { return oreoutput; }
        protected set
        {
            if (value < MIN_VALUE)
            {
                throw new ArgumentException("Harvester's OreOutput value is  negative!");
            }
            oreoutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return energyReqirement; }
        protected set
        {
            if (value < MIN_VALUE || value > MAX_VALUE)
            {
                throw new ArgumentException("Harvester's EnergyRequirement value is over 20000 or negative!");
            }
            oreoutput = value;
            energyReqirement = value;
        }
    }

    protected Harvester(string id, double oreoutput, double energyReqirement)
    {
        this.Id = id;
        this.OreOutput = oreoutput;
        this.EnergyRequirement = energyReqirement;
    }
}
