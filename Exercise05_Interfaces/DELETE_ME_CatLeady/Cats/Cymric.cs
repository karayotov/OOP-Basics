using System;
using System.Collections.Generic;
using System.Text;

public class Cymric : Cat, IMeasure
{

    public Cymric(string name, double furLength): base(name)
    {
        this.Size = furLength;
    }

    public double Size { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"{this.Size:f2}";
    }
}