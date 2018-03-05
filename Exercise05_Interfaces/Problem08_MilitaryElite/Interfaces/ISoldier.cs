using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Interfaces
{
    public interface ISoldier
    {
        string Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
