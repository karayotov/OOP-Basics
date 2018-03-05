using Problem08_MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder.ISpecialisedSoldiersFolder
{
    public interface IComando : ISoldier
    {
        List<IMission> Missions { get; }
    }
}
