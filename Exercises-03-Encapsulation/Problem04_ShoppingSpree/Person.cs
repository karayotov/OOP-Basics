using System;
using System.Collections.Generic;

public class Person
{
    private const int EMPTY_BAG = 0;
    private const string EMPTY = "";
    private const decimal MIN_VALUE = 0;
    private string name;
    private decimal money;
    private List<string> bag;


    public string Name
    {
        get { return name; }
        set
        {
            if (value == EMPTY)
            {
                throw new ArgumentException($"Name cannot be empty");
            }
            name = value;
        }
    }

    public decimal MoneyInThePocket
    {
        get { return money; }
        set
        {
            if (value < MIN_VALUE)
            {
                throw new ArgumentException($"Money cannot be negative");
            }
            money = value;
        }
    }

    public List<string> Bag
    {
        get { return bag; }
        set { bag = value; }
    }

    public Person(string name, decimal money)
    {
        Name = name;
        MoneyInThePocket = money;
        Bag = new List<string>();
    }

    public void ByProduct(Product product)
    {
        MoneyInThePocket -= product.Cost;
        Bag.Add(product.Name);
    }
}