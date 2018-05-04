using StorageMaster.Entities.VehiclesFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StorageMaster.Factories
{
    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string typeName)
        {
            Type type = Assembly.GetCallingAssembly().GetTypes().SingleOrDefault(t => t.Name == typeName);

            if (type == null)
            {
                throw new InvalidOperationException(Messages.invalidVehicleType);
            }

            return (Vehicle)Activator.CreateInstance(type);
        }
    }
}
