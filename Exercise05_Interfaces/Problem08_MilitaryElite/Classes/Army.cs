using Problem08_MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Classes
{
    public class Army
    {
        private string soldierType;
        private List<ISoldier> soldiers;

        public List<ISoldier> Soldiers
        {
            get { return soldiers; }
            set { soldiers = value; }
        }

        public string SoldierType
        {
            get { return soldierType; }
            set { soldierType = value; }
        }

        public Army()
        {
            Soldiers = new List<ISoldier>();
        }
        public Army(string soldierType) : base()
        {
            SoldierType = soldierType;
        }

    }
}
