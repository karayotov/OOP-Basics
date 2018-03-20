using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private const double MAX_FUEL = 160d;
    private const int NO_FUEL = 0;

    private double fuelAmount;


    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }


    public int Hp { get; }

    public double FuelAmount
    {
        get { return fuelAmount; }
        private set
        {
            if (value < NO_FUEL)
            {
                throw new ArgumentException(Messages.emptyFuelTank);
            }

            this.fuelAmount = Math.Min(value, MAX_FUEL);
        }
    }

    public Tyre Tyre { get; private set; }
}
