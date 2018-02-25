using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem04_ShoppingSpree
{
    class Shopping
    {
        private static List<Person> people = new List<Person>();
        private static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            AddCostumers(Console.ReadLine());
            AddProducts(Console.ReadLine());
            CashDesk();
            ComparingDicks();
        }

        private static void ComparingDicks()
        {
            foreach (var person in people)
            {
                string info = "Nothing bought";

                if (person.Bag.Count != 0)
                {
                    info = String.Join(", ", person.Bag);
                }

                Console.WriteLine(person.Name + " - " + info);
            }
        }

        private static void CashDesk()
        {
            string shopper;
            while ((shopper = Console.ReadLine()) != "END")
            {
                string[] thisCostumer = shopper.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                Person currentPerson = people.Find(a => a.Name == thisCostumer[0]);
                Product currentProduct = products.Find(p => p.Name == thisCostumer[1]);

                try
                {
                    currentPerson.ByProduct(currentProduct);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                    continue;
                }
                Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");                
            }
        }

        private static void AddProducts(string productToAdd)
        {
            string[] splitProducts = productToAdd.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string product in splitProducts)
            {
                string[] defineProduct = product.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string productName = defineProduct[0];
                decimal productMoney = decimal.Parse(defineProduct[1]);
                try
                {
                    products.Add(new Product(productName, productMoney));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        private static void AddCostumers(string costumers)
        {
            string[] splitPersons = costumers.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string person in splitPersons)
            {
                string[] definePerson = person.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string personName = definePerson[0];
                decimal personMoney = decimal.Parse(definePerson[1]);
                try
                {
                    people.Add(new Person(personName, personMoney));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}