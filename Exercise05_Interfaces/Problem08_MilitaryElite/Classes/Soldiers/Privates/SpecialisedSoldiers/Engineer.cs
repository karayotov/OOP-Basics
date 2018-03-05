using Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder.ISpecialisedSoldiersFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers
{
    public class Engineer : SpecialisedSoldeier, IEngineer
    {
        private List<IRepair> list;

        public List<IRepair> Repairs
        {
            get { return list; }
            set { list = value; }
        }
        public Engineer(string id, string firstName, string lastName, double salary, string corps)
            :base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<IRepair>();
        }

        public void AddRepair(IRepair repair)
        {
            Repairs.Add(repair);
        }
    }
}
//Engineer <id> <firstName> <lastName> <salary> <corps> <repair1Part> <repair1Hours> … <repairNPart> <repairNHours>