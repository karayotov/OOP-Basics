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

        public bool IsEmpty => this.Trunk.Any() == false;

        public bool IsFull => this.Trunk.Sum(p => p.Weight) >= this.Capacity;

        private Stack<Product> trunk;

        public Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.trunk = new Stack<Product>();
        }
        
        public int Capacity { get; }

        public IReadOnlyCollection<Product> Trunk => this.trunk;


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