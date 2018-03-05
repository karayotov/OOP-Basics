using Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder.ISpecialisedSoldiersFolder;

namespace Problem08_MilitaryElite
{
    public class Repair : IRepair
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
        public Repair(string part, int hoursWorked)
        {
            Part = part;
            HoursWorked = hoursWorked;
        }
    }
}
