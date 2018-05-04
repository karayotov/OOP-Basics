using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    public static class Messages
    {
        public static string priceCannotBeNegative = "Price cannot be negative!";

        public static string vehicleIsFull = "Vehicle is full!";

        public static string vehicleIsEmpty = "No products left in vehicle!";

        public static string invalidGarageSlot = "Invalid garage slot!";

        public static string emptyGarageSlot = "No vehicle in this garage slot!";

        public static string garageIsFull = "No room in garage!";

        public static string storageIsFull = "Storage is full!";

        public static string invalidProductType = "Invalid product type!";

        public static string invalidVehicleType = "Invalid vehicle type!";

        public static string invalidStorageType = "Invalid storage type!";

        public static string successfulAddedProductToPool = "Added {0} to pool";

        public static string successfulAddedStorageToRegistry = "Registered {0}";

        public static string successfulVehicleSelected = "Selected {0}";
        
        public static string productIsOutOfStock = "{0} is out of stock!";
        
        public static string loadedProductsToVehicleInfo = "Loaded {0}/{1} products into {2}";
        
        public static string invalidSourceStorage = "Invalid source storage!";

        public static string invalidDestinationStorage = "Invalid destination storage!";
        
        public static string vehicleTransferReport = "Sent {0} to {1} (slot {2})";

        public static string unloadedVehicleReport = "Unloaded {0}/{1} products at {2}";

        public static string emptySlot = "empty";

        public static string storageStatusProductsReport = "Stock ({0}/{1}): [{2}]";

        public static string storageStatusVehiclesReport = "Garage: [{0}]";
        
        public static string Error = "Error: {0}";

        public static string InvalidInputCommand = "Invalid input command! Something is wrong 👀";

        //public static string priceCannotBeNegative = "Price cannot be negative!";
    }
}
