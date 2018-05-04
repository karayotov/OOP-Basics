using StorageMaster.Entities.VehiclesFolder.ChildrenClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.StorageFolder.ChildrenClasses
{
    public class DistributionCenter : Storage
    {
        private const int CAPACITY = 2;

        private const int SLOTS = 5;

        public DistributionCenter(string name) : base(name, CAPACITY, SLOTS, new List<Van>() {new Van(), new Van(), new Van()})
        {
        }
    }
}
