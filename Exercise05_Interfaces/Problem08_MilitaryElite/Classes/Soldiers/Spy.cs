using Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite.Classes.Soldiers
{
    public class Spy : Soldier, ISpy
    {
        private string codeNumber;

        public string CodeNumber
        {
            get { return codeNumber; }
            set { codeNumber = value; }
        }
        public Spy(string id, string firstName, string lastName, string codeNumber)
            :base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }
    }
}
//Spy <id> <firstName> <lastName> <codeNumber>