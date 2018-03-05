using Problem08_MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers;
using Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder.ISpecialisedSoldiersFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite
{
    public class Comando : SpecialisedSoldeier, IComando
    {
        private List<IMission> list;

        public List<IMission> Missions
        {
            get { return list; }
            set { list = value; }
        }
        public Comando(string id, string firstName, string lastName, double salary, string corps)
            :base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<IMission>();
        }
    }
}
//Commando <id> <firstName> <lastName> <salary> <corps> <mission1CodeName>  <mission1state> … <missionNCodeName> <missionNstate>