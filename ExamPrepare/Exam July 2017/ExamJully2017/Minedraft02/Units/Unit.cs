using System;
using System.Collections.Generic;
using System.Text;

public abstract class Unit
{
    protected string Id { get; set; }

    protected Unit(string id)
    {
        Id = id;
    }
}
