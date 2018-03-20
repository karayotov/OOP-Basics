using System;
using System.Collections.Generic;
using System.Text;

public class UltrasoftTyre : Tyre
{
    private const int ULTRASOFT_BLOW_INDEX = 30;//Ultrasoft blows wen hit 30 points, not 0;


    public UltrasoftTyre( double hardness, double grip) : base("Ultrasoft", hardness)
    {
        this.Grip = grip;
        RecalculateData();
    }

    public double Grip { get; } //positiv number validation??

    private void RecalculateData()
    {
        base.Hardness += this.Grip;
        base.Degradation -= ULTRASOFT_BLOW_INDEX;
    }
}
