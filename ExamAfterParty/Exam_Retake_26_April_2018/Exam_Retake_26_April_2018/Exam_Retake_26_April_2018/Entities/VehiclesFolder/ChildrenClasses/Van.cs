using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.VehiclesFolder.ChildrenClasses
{
    public class Van : Vehicle
    {
        private const int CAPACITY = 2;

        public Van() : base(CAPACITY)
        {

        }
    }
}
