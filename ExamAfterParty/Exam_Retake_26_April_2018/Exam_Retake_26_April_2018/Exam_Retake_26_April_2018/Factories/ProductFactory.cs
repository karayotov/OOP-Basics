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
            Type type = this.GetType()
                .Assembly
                .GetTypes()
                .SingleOrDefault(t => typeof(Product).IsAssignableFrom(t) && !t.IsAbstract && t.Name == typeName);

            if (type == null)
            {
                throw new InvalidOperationException(Messages.invalidProductType);
            }

            try
            {
                return (Product)Activator.CreateInstance(type, price);
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }
    }
}
