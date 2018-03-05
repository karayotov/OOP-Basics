using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Interfaces.ISoldierFolder
{
    public interface IPrivate : ISoldier
    {
        double Salary { get; }
    }
}
