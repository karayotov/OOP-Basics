using System;
using System.Collections.Generic;
using System.Text;

public class Human : IBuyer
{
    private string name;
    private string age;
    private long food;

    public long Food
    {
        get { return food; }
        set { food = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Age
    {
        get { return age; }
        set { age = value; }
    }

    public Human(string name, string age)
    {
        Name = name;
        Age = age;
        Food = food;
    }

    public void BuyFood(IBuyer buyer)
    {
        if (buyer is Rebel)
        {
            Food += Rebel.CAPACITY;
        }
        else
        {
            Food += Citizen.CAPACITY;
        }
    }
}