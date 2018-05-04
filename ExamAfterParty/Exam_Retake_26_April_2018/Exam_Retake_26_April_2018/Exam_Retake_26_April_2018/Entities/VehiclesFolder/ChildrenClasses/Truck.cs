using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.VehiclesFolder.ChildrenClasses
{
    public class Truck : Vehicle
    {
        private const int CAPACITY = 5;

        public Truck() : base(CAPACITY)
        {

        }
    }
}