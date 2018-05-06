using StorageMaster.Entities.ProductsFolder;
using StorageMaster.Entities.StorageFolder;
using StorageMaster.Entities.VehiclesFolder;
using StorageMaster.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.BusinessLogic
{
    public class StorageMaster
    {
        Vehicle vehicle;

        List<Product> pool;
        List<Storage> storages;

        ProductFactory productFactory;

        StorageFactory storageFactory;

        VehicleFactory vehicleFactory;

        public StorageMaster()
        {
            this.storages = new List<Storage>();
            this.pool = new List<Product>();

            this.productFactory = new ProductFactory();
            this.storageFactory = new StorageFactory();
            this.vehicleFactory = new VehicleFactory();
        }

        public string AddProduct(string type, double price)
        {
            Product product = productFactory.CreateProduct(type, price);

            pool.Add(product);

            return string.Format(Messages.successfulAddedProductToPool, type);
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = storageFactory.CreateStorage(type, name);

            this.storages.Add(storage);

            return string.Format(Messages.successfulAddedStorageToRegistry, name);
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            this.vehicle = this.SelectStorage(storageName).GetVehicle(garageSlot);

            return string.Format(Messages.successfulVehicleSelected, this.vehicle.GetType().Name);
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProductsCount = 0;

            int productCount = productNames.Count();

            foreach (string productName in productNames)
            {
                Product product = this.pool.LastOrDefault(p => p.GetType().Name == productName);

                if (product == null)
                {
                    throw new InvalidOperationException(string.Format(Messages.productIsOutOfStock, productName));
                }
                else
                {
                    if (vehicle.IsFull == false)
                    {
                        int lastIndex = this.pool.LastIndexOf(product);

                        this.pool.RemoveAt(lastIndex);

                        this.vehicle.LoadProduct(product);

                        loadedProductsCount++;
                    }
                }
            }

            return string.Format(Messages.loadedProductsToVehicleInfo, loadedProductsCount, productCount, this.vehicle.GetType().Name);
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (this.storages.Any(s => s.Name == sourceName) == false)
            {
                throw new InvalidOperationException(Messages.invalidSourceStorage);
            }

            if (this.storages.Any(s => s.Name == destinationName) == false)
            {
                throw new InvalidOperationException(Messages.invalidDestinationStorage);
            }

            int garageSlot = this.SelectStorage(sourceName)
                .SendVehicleTo(sourceGarageSlot, this.SelectStorage(destinationName));

            string vehicleType = this.SelectStorage(destinationName).GetVehicle(garageSlot).GetType().Name;

            return string.Format(Messages.vehicleTransferReport, vehicleType, destinationName, garageSlot);
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {

            Vehicle vehicle = this.SelectStorage(storageName).GetVehicle(garageSlot);

            int productsInVehicle = vehicle.Trunk.Count;

            int unloadedProductCount = this.SelectStorage(storageName).UnloadVehicle(garageSlot);

            return string.Format(Messages.unloadedVehicleReport, unloadedProductCount, productsInVehicle, storageName).Trim();
        }

        public string GetStorageStatus(string storageName)
        {
            StringBuilder sb = new StringBuilder();


            Storage storage = this.SelectStorage(storageName);

            int productsCount = storage.Products.Count;

            Dictionary<string, List<Product>> sortedProducts = SortTheProducts(storage);

            string[] productsInfo = RetrieveProductsInfo(sortedProducts);

            string[]  vehicleNamesCollection = RetrieveAllVehiclesNames(storage);


            double sumOfTheProductsWeight = storage.Products.Sum(p => p.Weight);



            string firstLine = String.Format(Messages.storageStatusProductsReport,
                sumOfTheProductsWeight, storage.Capacity, string.Join(", ", productsInfo));

            string secondLine = string.Format(Messages.storageStatusVehiclesReport, string.Join('|', vehicleNamesCollection).Trim());

            sb.AppendLine(firstLine);
            sb.AppendLine(secondLine);

            return sb.ToString();
        }

        public string GetSummary()
        {
            this.storages = this.storages.OrderByDescending(s => s.Products.Sum(p => p.Price)).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var storage in this.storages)
            {
                sb.AppendLine(storage.ToString());
            }

            return sb.ToString();
        }

        private Storage SelectStorage(string storageName)
        {
            return this.storages.Single(s => s.Name == storageName);
        }

        private Dictionary<string, List<Product>> SortTheProducts(Storage storage)
        {
            Dictionary<string, List<Product>> sortedProducts = new Dictionary<string, List<Product>>();

            foreach (var product in storage.Products)
            {
                string productName = product.GetType().Name;

                if (sortedProducts.Any(p => p.Key == productName) == false)
                {
                    sortedProducts[productName] = new List<Product>();
                }

                sortedProducts[productName].Add(product);
            }

            sortedProducts = new Dictionary<string, List<Product>>(sortedProducts.OrderByDescending(pair => pair.Value.Count).ThenBy(pair => pair.Key));

            return sortedProducts;
        }

        private string[] RetrieveProductsInfo(Dictionary<string, List<Product>> sortedProducts)
        {
            string[] productsInfo = new string[sortedProducts.Count];

            for (int i = 0; i < sortedProducts.Count; i++)
            {
                var pair = sortedProducts.ElementAt(i);

                string productInfo = $"{pair.Key} ({pair.Value.Count})";

                productsInfo[i] = productInfo;
            }

            return productsInfo;
        }

        private string[] RetrieveAllVehiclesNames(Storage storage)
        {
            string name;

            string[] namesCollection = new string[storage.Garage.Count];

            for (int slot = 0; slot < storage.Garage.Count; slot++)
            {
                Vehicle garageSlot = storage.Garage.ElementAt(slot);

                if (garageSlot == null)
                {
                    name = Messages.emptySlot;
                }
                else
                {
                    name = garageSlot.GetType().Name;
                }

                namesCollection[slot] = name;
            }

            return namesCollection;
        }

    }
}
