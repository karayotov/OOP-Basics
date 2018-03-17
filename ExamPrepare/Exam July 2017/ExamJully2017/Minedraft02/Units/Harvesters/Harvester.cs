using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester : Unit
{
    protected Harvester(string id, double oreOutput, double energyRequirement) : base(id)
    {
        OreOutput = oreOutput;
        EnergyRequirement = energyRequirement;
    }

    private const int MIN_VALUE = 0;

    private const int MAX_VALUE = 20_000;

    private double oreOutput;

    private double energyRequirement;

    public double OreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value < MIN_VALUE)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's OreOutput");
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
                throw new ArgumentException(string.Format(Messages.InvalidHarvesterRegistration, nameof(EnergyRequirement)));
            }
            energyRequirement = value;
        }
    }

    public override string ToString()
    {
        //return $"{Type} Harvester - {Id}" + Environment.NewLine +
        //    $"Ore Output: {OreOutput}" + Environment.NewLine +
        //    $"Energy Requirement: { EnergyRequirement}";

        return string.Format(Messages.ToStringHarvester,
            this.Type, this.Id,
            Environment.NewLine, this.OreOutput,
            Environment.NewLine, this.EnergyRequirement);
        //type, id , Environment.NewLine, oreOutput, Environment.NewLine, energyRequired
    }
}
