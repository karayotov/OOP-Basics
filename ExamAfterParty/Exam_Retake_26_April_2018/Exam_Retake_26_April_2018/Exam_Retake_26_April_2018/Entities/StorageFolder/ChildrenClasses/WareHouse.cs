using StorageMaster.Entities.VehiclesFolder.ChildrenClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.StorageFolder.ChildrenClasses
{
    public class Warehouse : Storage
    {
        private const int CAPACITY = 10;

        private const int SLOTS = 10;

        public Warehouse(string name) : base(name, CAPACITY, SLOTS, new List<Semi>() { new Semi(), new Semi(), new Semi()})
        {
        }
    }
}
