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
            Type type = this.GetType()
                .Assembly
                .GetTypes()
                .SingleOrDefault(t => typeof(Vehicle).IsAssignableFrom(t) && !t.IsAbstract && t.Name == typeName);

            if (type == null)
            {
                throw new InvalidOperationException(Messages.invalidVehicleType);
            }

            try
            {
                return (Vehicle)Activator.CreateInstance(type);
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }
    }
}