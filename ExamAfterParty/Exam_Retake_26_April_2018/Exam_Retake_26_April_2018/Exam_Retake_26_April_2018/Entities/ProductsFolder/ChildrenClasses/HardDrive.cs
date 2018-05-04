using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.ProductsFolder.ChildrenClasses
{
    public class HardDrive : Product
    {
        private const double WEIGHT = 1.0d;

        public HardDrive(double price) : base(price, WEIGHT)
        {

        }


    }
}
