using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.ProductsFolder
{
    public abstract class Product
    {
        private const int MIN_VALUE = 0;

        private double price;

        protected Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public double Price
        {
            get { return price; }
            private set
            {
                if (value < MIN_VALUE)
                {
                    throw new InvalidOperationException(Messages.priceCannotBeNegative);
                }

                price = value;
            }
        }

        public double Weight { get; }
    }
}
