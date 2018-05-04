using StorageMaster.Entities.ProductsFolder;
using StorageMaster.Entities.VehiclesFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.StorageFolder
{
    public abstract class Storage
    {
        private bool isFull;

        private List<Product> products;

        private List<Vehicle> vehicles;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;

            this.Capacity = capacity;

            this.GarageSlots = garageSlots;

            this.products = new List<Product>();

            this.vehicles = new List<Vehicle>(new Vehicle[this.GarageSlots]);

            this.AddDefaultVehicles(vehicles);

            this.vehicles.AddRange(vehicles);

        }

        private void AddDefaultVehicles(IEnumerable<Vehicle> vehicles)
        {
            for (int i = 0; i < vehicles.Count(); i++)
            {
                this.vehicles[i] = vehicles.ElementAt(i);
            }
        }

        public string Name { get; }

        public int Capacity { get; }

        public int GarageSlots { get; }

        public IReadOnlyCollection<Product> Products => this.products;

        public IReadOnlyCollection<Vehicle> Garage => this.vehicles;

        public bool IsFull => this.Products.Sum(p => p.Weight) >= this.Capacity;

        private bool IsThereFreeGarageSlot(Storage deliveryLocation)
        {
            return deliveryLocation.Garage.Any(v => v == null);
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException(Messages.invalidGarageSlot);
            }

            if (this.vehicles[garageSlot] == null)
            {
                throw new InvalidOperationException(Messages.emptyGarageSlot);
            }

            return this.vehicles[garageSlot];
        }

        private void EmptyGargeSlot(int garageSlot)
        {
            this.vehicles[garageSlot] = null;
        }

        private int AddVehicleToGarage(Vehicle vehicle)
        {
            int garageSlot = 0;

            for (int i = 0; i < this.vehicles.Count(); i++)
            {
                if (this.vehicles[i] == null)
                {
                    garageSlot = i;
                    break;
                }
            }

            this.vehicles[garageSlot] = vehicle;

            return garageSlot;//must be unreachable!!!
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(garageSlot);

            if (this.IsThereFreeGarageSlot(deliveryLocation) == false)
            {
                throw new InvalidOperationException(Messages.garageIsFull);
            }

            this.EmptyGargeSlot(garageSlot);

            return deliveryLocation.AddVehicleToGarage(vehicle);
        }

        public int UnloadVehicle(int garageSlot)
        {
            int unloadedProductsCount = 0;

            if (this.IsFull)
            {
                throw new InvalidOperationException(Messages.storageIsFull);
            }

            Vehicle vehicle = this.GetVehicle(garageSlot);

            while ((vehicle.IsEmpty || this.IsFull) == false)
            {
                Product product = vehicle.Unload();

                this.products.Add(product);

                unloadedProductsCount++;
            }

            return unloadedProductsCount;
        }

        public override string ToString()
        {
            return $"{this.Name}:{Environment.NewLine}Storage worth: ${products.Sum(p => p.Price):F2}";
        }
    }
}
