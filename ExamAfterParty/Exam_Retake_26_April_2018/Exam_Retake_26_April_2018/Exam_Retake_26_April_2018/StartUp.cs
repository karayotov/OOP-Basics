using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster
{
    using StorageMaster.BusinessLogic;
    using System.Text;

    public class StartUp
    {
        private const string END = "END";
        private const string ADD_PRODUCT = "AddProduct";
        private const string REGISTERS_TORAGE = "RegisterStorage";
        private const string SELECT_VEHICLE = "SelectVehicle";
        private const string LOAD_VEHICLE = "LoadVehicle";
        private const string SEND_VEHICLE_TO = "SendVehicleTo";
        private const string UNLOAD_VEHICLE = "UnloadVehicle";
        private const string GET_STORAGE_STATUS = "GetStorageStatus";


        static void Main(string[] args)
        {
            StorageMaster storageMaster = new StorageMaster();

            string inputLine;

            StringBuilder sb = new StringBuilder();

            while ((inputLine = Console.ReadLine()) != END)
            {
                List<string> collection = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string command = collection[0];

                collection.RemoveAt(0);
                try
                {
                    switch (command)
                    {
                        case ADD_PRODUCT:
                            sb.AppendLine(storageMaster.AddProduct(collection[0], double.Parse(collection[1])));
                            break;

                        case REGISTERS_TORAGE:
                            sb.AppendLine(storageMaster.RegisterStorage(collection[0], collection[1]));
                            break;

                        case SELECT_VEHICLE:
                            sb.AppendLine(storageMaster.SelectVehicle(collection[0], int.Parse(collection[1])));
                            break;

                        case LOAD_VEHICLE:
                            sb.AppendLine(storageMaster.LoadVehicle(collection));
                            break;

                        case SEND_VEHICLE_TO:
                            sb.AppendLine(storageMaster.SendVehicleTo(collection[0], int.Parse(collection[1]), collection[2]));
                            break;

                        case UNLOAD_VEHICLE:
                            sb.AppendLine(storageMaster.UnloadVehicle(collection[0], int.Parse(collection[1])));
                            break;

                        case GET_STORAGE_STATUS:
                            sb.AppendLine(storageMaster.GetStorageStatus(collection[0]));
                            break;

                        default:
                            throw new EntryPointNotFoundException(Messages.InvalidInputCommand);
                    }
                }
                catch (InvalidOperationException m)
                {
                    sb.AppendLine(string.Format(Messages.Error, m.Message));
                }
            }

            sb.AppendLine(storageMaster.GetSummary());



            Console.WriteLine(sb.ToString());
        }
    }
}