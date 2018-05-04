using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.ProductsFolder.ChildrenClasses
{
    public class Ram : Product
    {
        private const double WEIGHT = 0.1d;

        public Ram(double price) : base(price, WEIGHT)
        {

        }

    }
}
