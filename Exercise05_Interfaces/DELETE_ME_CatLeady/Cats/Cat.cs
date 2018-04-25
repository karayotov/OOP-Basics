using System;
using System.Collections.Generic;
using System.Text;

public abstract class Cat
{
    public Cat(string name)
    {
        this.Name = name;
    }

    public string Name { get; protected set; }

    public override string ToString()
    {
        return $"{this.GetType()} {this.Name} ";
    }
}