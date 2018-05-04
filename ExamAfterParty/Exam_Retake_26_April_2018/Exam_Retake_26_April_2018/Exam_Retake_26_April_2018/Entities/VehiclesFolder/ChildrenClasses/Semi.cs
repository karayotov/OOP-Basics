using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.VehiclesFolder.ChildrenClasses
{
    public class Semi : Vehicle
    {
        private const int CAPACITY = 10;

        public Semi() : base(CAPACITY)
        {

        }
    }
}
