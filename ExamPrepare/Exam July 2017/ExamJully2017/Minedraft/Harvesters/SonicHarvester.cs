using System;
using System.Collections.Generic;
using System.Text;

public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public int SonicFactor
    {
        get { return sonicFactor; }
        private set
        {
            sonicFactor = value;
        }
    }

    public SonicHarvester(string id, double oreoutput, double energyReqirement, int sonicFactor)
        : base(id, oreoutput, energyReqirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement /= sonicFactor;
    }
}