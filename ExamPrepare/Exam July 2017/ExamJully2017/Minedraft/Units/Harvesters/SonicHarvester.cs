using System;
using System.Collections.Generic;
using System.Text;

public class SonicHarvester : Harvester
{
    public override string Type => "Sonic";

    public SonicHarvester(string id, double oreoutput, double energyReqirement, int sonicFactor)
        : base(id, oreoutput, energyReqirement / sonicFactor)
    {
    }
}