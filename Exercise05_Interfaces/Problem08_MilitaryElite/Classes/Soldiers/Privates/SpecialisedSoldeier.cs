using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite
{
    public class SpecialisedSoldeier
    {
        private const string AIRFORCES = "Airforces";
        private const string MARINES = "Marines";

        private string corps;

        public string Corps
        {
            get { return corps; }
            set
            {
                if (value != AIRFORCES || value != MARINES)
                {
                    throw new ArgumentException($"{AIRFORCES} or {MARINES} corps allowed");
                }
                corps = value;
            }
        }

    }
}
