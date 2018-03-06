using Problem08_MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem08_MilitaryElite
{
    public class Soldier : ISoldier
    {
        private string id;
        private string firstName;
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public Soldier(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        
    }
}
