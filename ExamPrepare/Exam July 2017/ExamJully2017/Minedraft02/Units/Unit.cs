using System;
using System.Collections.Generic;
using System.Text;

public abstract class Unit
{
    public string Id { get; }

    public abstract string Type { get; }

    protected Unit(string id)
    {
        Id = id;
    }
}
