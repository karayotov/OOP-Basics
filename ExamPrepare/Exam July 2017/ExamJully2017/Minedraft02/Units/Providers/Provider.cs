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
            if (value < MIN_VALUE || value > MAX_VALUE)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }

            energyOutput = value;
        }
    }

    protected Provider(string id, double energyOutput) : base(id)
    {
        EnergyOutput = energyOutput;
    }

    public override string ToString()
    {
        //return $"{Type} Provider - {Id}" + Environment.NewLine +
        //    $"Energy Output: {EnergyOutput}";

        return string.Format(Messages.ToStringProvider,
            this.Type, this.Id,
            Environment.NewLine, this.energyOutput);//type, id, Environment.NewLine, energyOutput
    }
}
