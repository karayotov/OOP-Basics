using Problem08_MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite
{
    public class Repairs
    {
        private string part;
        private int hoursWorked;

        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        public string Part
        {
            get { return part; }
            set { part = value; }
        }

    }
}
