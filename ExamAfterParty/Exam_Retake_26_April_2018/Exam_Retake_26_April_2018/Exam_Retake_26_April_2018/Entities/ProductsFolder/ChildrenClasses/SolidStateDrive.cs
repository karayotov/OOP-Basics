using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.ProductsFolder.ChildrenClasses
{
    public class SolidStateDrive : Product
    {
        private const double WEIGHT = 0.2d;

        public SolidStateDrive(double price) : base(price, WEIGHT)
        {

        }


    }
}
