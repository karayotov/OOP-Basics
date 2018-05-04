using StorageMaster.Entities.ProductsFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StorageMaster.Factories
{
    public class ProductFactory
    {
        public Product CreateProduct(string typeName, double price)
        {
            Type type = Assembly.GetCallingAssembly().GetTypes().SingleOrDefault(t => t.Name == typeName);

            if (type == null)
            {
                throw new InvalidOperationException(Messages.invalidProductType);
            }

            return (Product)Activator.CreateInstance(type, price);
        }

    }
}
