using Problem08_MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite
{
    public class Comando
    {
        private List<Mission> list;

        public List<Mission> Missions
        {
            get { return list; }
            set { list = value; }
        }
    }
}
