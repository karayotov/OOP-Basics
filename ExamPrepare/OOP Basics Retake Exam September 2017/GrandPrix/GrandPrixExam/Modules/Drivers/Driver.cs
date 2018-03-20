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

    public double TotalTime { get; set; }

    public Car Car { get; }

    public double FuelConsumptionPerKm { get; } // Learn how to use abstract int or double

    public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / Car.FuelAmount;
}