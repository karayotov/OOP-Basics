public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) : base(id)
    {
        base.EnergyOutput = energyOutput * 1.5;
    }
}