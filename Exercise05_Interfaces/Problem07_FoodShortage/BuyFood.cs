using System;
using System.Collections.Generic;
using System.Linq;

class BuyFood
{
    public static List<IBuyer> potentionalBuyers = new List<IBuyer>();
    static void Main(string[] args)
    {
        int peopleToAdd = int.Parse(Console.ReadLine());

        for (int i = 0; i < peopleToAdd; i++)
        {
            string[] buyerData = Console.ReadLine().Split();

            IBuyer buyer;

            if (buyerData.Length == 4)
            {
                buyer = new Citizen(buyerData[0], buyerData[1], buyerData[2], buyerData[3]);
            }
            else if (buyerData.Length == 3)
            {
                buyer = new Rebel(buyerData[0], buyerData[1], buyerData[2]);
            }
            else continue;

            potentionalBuyers.Add(buyer);
        }
        string buyerName;

        while ((buyerName = Console.ReadLine()) != "End")
        {
            foreach (var buyer in potentionalBuyers)
            {
                if (buyer.Name == buyerName)
                {
                    buyer.BuyFood(buyer);
                }
            }
        }

        Console.WriteLine(potentionalBuyers.Sum(a => a.Food));
    }
}