using System;

public abstract class Provider : Unit
{
    private static int MIN_VALUE = 0;
    private static int MAX_VALUE = 9_999;
    private double energyOutput;

    public double EnergyOutput
    {
        get { return energyOutput; }
        protected set
        {
            if (value < 0 || value > MAX_VALUE)
            {
                throw new ArgumentException($"");
            }

            energyOutput = value;
        }
    }

    public Provider(string id) : base(id)
    {
    }
}
