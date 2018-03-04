using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers
{
    public class Engineer
    {
        private List<Repairs> list;

        public List<Repairs> Repairs
        {
            get { return list; }
            set { list = value; }
        }
    }
}
