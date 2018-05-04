using StorageMaster.Entities.StorageFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StorageMaster.Factories
{
    public class StorageFactory
    {
        public Storage CreateStorage(string typeName, string name)
        {
            Type type = Assembly.GetCallingAssembly().GetTypes().SingleOrDefault(t => t.Name == typeName);

            if (type == null)
            {
                throw new InvalidOperationException(Messages.invalidStorageType);
            }

            return (Storage)Activator.CreateInstance(type, name);
        }
    }
}
