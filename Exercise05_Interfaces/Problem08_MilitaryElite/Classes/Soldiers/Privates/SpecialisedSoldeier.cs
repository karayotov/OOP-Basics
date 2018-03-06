using Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite
{
    public abstract class SpecialisedSoldeier : Private, ISpecialisedSoldier
    {
        private const string AIRFORCES = "Airforces";
        private const string MARINES = "Marines";

        private string corps;

        public string Corps
        {
            get { return corps; }
            set
            {
                if (value != AIRFORCES && value != MARINES)
                {
                    throw new ArgumentException($"{AIRFORCES} or {MARINES} corps allowed");
                }
                corps = value;
            }
        }
        public SpecialisedSoldeier(string id, string firstName, string lastName, double salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public override string ToString()
        {
            var result =  base.ToString();

            result += $"neshto ";

            return result;
        }

    }
}
