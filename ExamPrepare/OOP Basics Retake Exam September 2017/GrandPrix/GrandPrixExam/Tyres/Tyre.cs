using System;

public abstract class Tyre
{
    private const int BLOW_POINT = 0;
    private const int NEW_TYRE = 100;
    public double degradation;

    protected Tyre(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        this.Degradation = NEW_TYRE;
    }


    public string Name { get; }

    public double Hardness { get; protected set; }

    public double Degradation
    {
        get { return degradation; }
        protected set
        {
            if (value < BLOW_POINT)
            {
                throw new ArgumentException(Messages.blowedTyre);
            }
            degradation = value;
        }
    }


    public virtual void DegradateTyre()
    {
        this.Degradation -= this.Hardness;
    }
}