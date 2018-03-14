using System;
using System.Collections.Generic;
using System.Text;

public class HammerHarvester : Harvester
{
    public override string Type => "Hammer";

    public HammerHarvester(string id, double oreoutput, double energyReqirement)
        : base(id, oreoutput * 3, energyReqirement * 2)
    {
    }
}