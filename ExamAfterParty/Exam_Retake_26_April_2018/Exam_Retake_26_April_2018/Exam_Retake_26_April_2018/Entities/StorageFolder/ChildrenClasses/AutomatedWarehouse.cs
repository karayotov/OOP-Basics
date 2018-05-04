using StorageMaster.Entities.VehiclesFolder;
using StorageMaster.Entities.VehiclesFolder.ChildrenClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.StorageFolder.ChildrenClasses
{
    public class AutomatedWarehouse : Storage
    {
        private const int CAPACITY = 1;

        private const int SLOTS = 2;

        public AutomatedWarehouse(string name) : base(name, CAPACITY, SLOTS, new List<Truck>() { new Truck() })
        {
        }
    }
}
