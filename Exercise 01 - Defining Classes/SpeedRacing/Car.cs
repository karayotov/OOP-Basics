using System;
using System.Collections.Generic;
using System.Text;

class Car
{
    string model;
    double fuelAmount;
    double fuelConsumptionPerKilometer;
    int distanceTraveled;
    double howFarCanGo;

    public string Model { get => model; set => model = value; }
    public double FuelAmount { get => fuelAmount; set => fuelAmount = value; }
    public double FuelConsumptionPerKilometer { get => fuelConsumptionPerKilometer; set => fuelConsumptionPerKilometer = value; }
    public int DistanceTraveled { get => distanceTraveled; set => distanceTraveled = value; }
    public double HowFarCanGo { get => howFarCanGo; set => howFarCanGo = value; }

    public Car(int fuel, double consumptionPerKm)
    {
        FuelAmount = fuel;
        FuelConsumptionPerKilometer = consumptionPerKm;
        HowFarCanGo = FuelAmount / FuelConsumptionPerKilometer;
        
    }

    public Car(string model, int fuel, double consumptionPerKm)
        :this(fuel, consumptionPerKm)
    {
        Model = model;
    }

    public void HitTheRoad(int distance)
    {
        if (HowFarCanGo >= distance)
        {
            FuelAmount -= distance * FuelConsumptionPerKilometer;
            DistanceTraveled += distance;
            HowFarCanGo -= distance;
        }
        else
        {
            Console.WriteLine($"Insufficient fuel for the drive");
        }
    }

    public void PrintCar(Car car)
    {
        Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
    }
}