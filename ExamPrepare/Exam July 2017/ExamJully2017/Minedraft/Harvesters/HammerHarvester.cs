using System;
using System.Collections.Generic;
using System.Text;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreoutput, double energyReqirement)
        : base(id, oreoutput, energyReqirement)
    {
        this.OreOutput += oreoutput * 200 / 100; //increase by 200%
        this.EnergyRequirement += energyReqirement * 100 / 100; //increase by 100%
    }
}