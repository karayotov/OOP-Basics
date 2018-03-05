using Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder.ISpecialisedSoldiersFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers
{
    public class Mission : IMission
    {
        private const string IN_PROGRESS = "inProgress";
        private const string FINISHED = "finished";
        private string codeName;
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                if (value != IN_PROGRESS && value != FINISHED) //----> inProgress only, use CompleteMission() for setting as "Finished" ?
                {
                    throw new ArgumentException("Invalid mission state!");
                }
                state = value;
            }
        }

        public string CodeName
        {
            get { return codeName; }
            set { codeName = value; }
        }

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }
        public void CompleteMission()
        {
            CodeName = FINISHED;
        }
    }
}
