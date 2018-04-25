using System;
using System.Collections.Generic;
using System.Text;

public class Siamese : Cat, IMyalable
{
    public Siamese(string name, int size) : base(name)
    {
        this.MyauCount = size;
    }

    public int MyauCount { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"{this.MyauCount}";
    }
}