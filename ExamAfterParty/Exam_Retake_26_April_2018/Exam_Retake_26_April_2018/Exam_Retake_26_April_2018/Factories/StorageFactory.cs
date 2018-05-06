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
            Type type = this.GetType()
                .Assembly
                .GetTypes()
                .SingleOrDefault(t => typeof(Storage).IsAssignableFrom(t) && !t.IsAbstract && t.Name == typeName);

            if (type == null)
            {
                throw new InvalidOperationException(Messages.invalidStorageType);
            }

            try
            {

                return (Storage)Activator.CreateInstance(type, name);
            }
            catch (TargetInvocationException e)
            {

                throw e.InnerException;
            }
        }
    }
}
