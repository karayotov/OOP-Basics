using System;
using System.Collections.Generic;
using System.Text;

public abstract class Provider : Unit
{
    private const int MIN_VALUE = 0;
    private const int MAX_VALUE = 10_000;
    private double energyOutput;

    public double EnergyOutput
    {
        get { return energyOutput; }
        private set
        {
            if (value < MIN_VALUE || value >= MAX_VALUE)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            energyOutput = value;
        }
    }

    protected Provider(string id, double energyOutput) : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public override string ToString()
    {
        return $"{Type} Provider - {Id}" + Environment.NewLine +
            $"Energy Output: {EnergyOutput}";
    }
}