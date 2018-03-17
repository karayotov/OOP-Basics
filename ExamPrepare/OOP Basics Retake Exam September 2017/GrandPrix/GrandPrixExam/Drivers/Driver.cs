using System;
using System.Collections.Generic;
using System.Text;

public abstract class Driver
{ 

    protected Driver(string name, Car car, double fuelConsumption)
    {
        this.Name = name;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumption;
        this.TotalTime = 0d;
    }

    public string Name { get; }

    public double TotalTime { get; private set; }

    public Car Car { get; private set; }

    public double FuelConsumptionPerKm { get; protected set; } // Learn how to use abstract int or double

    public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / Car.FuelAmount;
}