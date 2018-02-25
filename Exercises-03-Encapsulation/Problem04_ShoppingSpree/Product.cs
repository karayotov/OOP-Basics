using System;

public class Product
{
    private const string EMPTY_STRING = "";
    private const decimal MIN_VALUE = 0;
    private string name;
    private decimal cost;
    
    public string Name
    {
        get { return name; }
        set
        {
            if (value == EMPTY_STRING)
            {
                throw new ArgumentException($"Name cannot be empty");
            }
            name = value;
        }
    }

    public decimal Cost
    {
        get { return cost; }
        set
        {
            if (value <= MIN_VALUE) //<---- product is for free?
            {
                throw new ArgumentException($"Money cannot be negative");
            }
            cost = value;
        }
    }

    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}