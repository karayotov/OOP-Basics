using System;
using System.Collections.Generic;
using System.Text;

public abstract class Unit
{
    public string Id { get; private set; }

    public abstract string Type { get; }//при ABSTRACT наследниците са задължени да го имплементират

    protected Unit(string id)
    {
        Id = id;
    }
}
