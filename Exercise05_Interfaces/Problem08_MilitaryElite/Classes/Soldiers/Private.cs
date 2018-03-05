using Problem08_MilitaryElite.Interfaces.ISoldierFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite
{
    public class Private : Soldier, IPrivate
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Private(string id, string firstName, string lastName, double salary) : base(id, firstName, lastName)
        {
            Salary = salary;
        }
    }
}
//•	Private: “Private <id> <firstName> <lastName> <salary>”