using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder
{
    public interface ILeutenantGeneral : ISoldier
    {
        List<ISoldier> Privates { get; }
    }
}
