using System;
using System.Collections.Generic;
using System.Text;

public abstract class Provider
{
    private const int MIN_VALUE = 0;
    private const int MAX_VALUE = 10_000;
    private string id;
    private double energyOutput;

    public string Id
    {
        get { return id; }
        protected set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid Provider Id value!");
            }
            id = value;
        }
    }

    public double EnergyOutput
    {
        get { return energyOutput; }
        protected set
        {
            if (value < MIN_VALUE || value > MAX_VALUE)
            {
                throw new ArgumentException("Provider's EnergyOutput value is over 20000 or negative!");
            }
            energyOutput = value;
        }
    }

    protected Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }
}
