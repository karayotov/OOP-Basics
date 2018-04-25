using System;
using System.Collections.Generic;
using System.Text;

public class StreetExtraordinaire : Cat, IMyalable
{
    public StreetExtraordinaire(string name, int myauCount) : base(name)
    {
        MyauCount = myauCount;
    }

    public int MyauCount { get; set; }

    public override string ToString()
    {
        return base.ToString() + this.MyauCount;
    }
}
