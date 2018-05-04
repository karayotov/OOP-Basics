using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.ProductsFolder.ChildrenClasses
{
    public class Gpu : Product
    {
        private const double WEIGHT = 0.7d;

        public Gpu(double price) : base(price, WEIGHT)
        {

        }

    }
}
