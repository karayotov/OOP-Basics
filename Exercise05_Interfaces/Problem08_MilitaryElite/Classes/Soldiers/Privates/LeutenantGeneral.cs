using Problem08_MilitaryElite.Interfaces;
using Problem08_MilitaryElite.Interfaces.ISoldierFolder;
using Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        private List<ISoldier> privates;

        public List<ISoldier> Privates
        {
            get { return privates; }
            set { privates = value; }
        }
        public LeutenantGeneral(string id, string firstName, string lastName, double salary) 
            : base(id, firstName, lastName, salary)
        {
            Privates = new List<ISoldier>();
        }

    }
}
//LeutenantGeneral <id> <firstName> <lastName> <salary> <private1Id> <private2Id> … <privateNId>
//  where privateXId will always be an Id of a private already received through the input.
