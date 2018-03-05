using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder.ISpecialisedSoldiersFolder
{
    public interface IEngineer : ISoldier
    {
        List<IRepair> Repairs { get; }
        void AddRepair(IRepair repair);
    }
}
