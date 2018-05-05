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
            Type[] Alltypes = Assembly
                .GetCallingAssembly()
                .GetTypes();

            if (Alltypes.Any(t => typeof(Vehicle).IsAssignableFrom(t)) == false)
            {
                throw new InvalidOperationException(Messages.invalidVehicleType);
            }

            Type setType = Alltypes
                .SingleOrDefault(t => t.Name == typeName);

            return (Vehicle)Activator.CreateInstance(setType);
        }
    }
}