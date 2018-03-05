using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder.ISpecialisedSoldiersFolder
{
    public interface IRepair
    {
        string Part { get; }
        int HoursWorked { get; }
    }
}
