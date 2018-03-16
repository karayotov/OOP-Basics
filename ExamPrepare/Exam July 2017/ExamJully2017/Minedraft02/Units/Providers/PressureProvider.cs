public class PressureProvider : Provider
{
    public override string Type => "Pressure";

    public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
    {
        base.EnergyOutput = energyOutput * 1.5;
    }
}