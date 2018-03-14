public class SolarProvider : Provider
{
    public SolarProvider(string id, double energyOutput) : base(id)
    {
        base.EnergyOutput = energyOutput;
    }
}