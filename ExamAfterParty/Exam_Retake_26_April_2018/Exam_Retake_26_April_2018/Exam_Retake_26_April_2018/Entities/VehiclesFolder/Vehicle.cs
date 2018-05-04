using StorageMaster.Entities.ProductsFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.VehiclesFolder
{
    public abstract class Vehicle
    {
        private const int ZeroCountProducts = 0;

        private bool isEmpty;

        private bool isFull;

        private Stack<Product> trunk;

        public Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.trunk = new Stack<Product>();
        }
        
        public int Capacity { get; }

        public IReadOnlyCollection<Product> Trunk => this.trunk;

        public bool IsFull
        {
            get { return isFull; }
            set
            {
                if (IsFullValidation())
                {
                    isFull = true;
                }
                else
                {
                    isFull = false;
                }
            }
        }

        public bool IsEmpty
        {
            get { return isEmpty; }
            set
            {
                if (IsEmptyValidation())
                {
                    isEmpty = true;
                }
                else
                {
                    isEmpty = false;
                }
            }
        }

        private bool IsFullValidation()
        {
            var sumOfProductsWeight = this.Trunk.Sum(p => p.Weight);

            if (sumOfProductsWeight >= this.Capacity)
            {
                return true;
            }
            return false;
        }

        private bool IsEmptyValidation()
        {
            int productsInTheTrunk = this.Trunk.Count;

            if (productsInTheTrunk != ZeroCountProducts)
            {
                return false;
            }

            return true;
        }


        public void LoadProduct(Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException(Messages.vehicleIsFull);
            }

            this.trunk.Push(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException(Messages.vehicleIsEmpty);
            }

            return trunk.Pop();
        }
    }
}