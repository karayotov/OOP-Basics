using System;
using System.Collections.Generic;

class CarData
{
    static void Main(string[] args)
    {
        List<Car> carColection = AddCars(int.Parse(Console.ReadLine()));

        VehicleDiagnostic(Console.ReadLine(), carColection);
    }

    private static void VehicleDiagnostic(string checkThisCargo, List<Car> cars)
    {
        switch (checkThisCargo)
        {
            case "fragile":
                FragileCase(cars, checkThisCargo);
                break;

            case "flamable":
                FlamableCase(cars, checkThisCargo);
                break;
        }
    }

    private static void FlamableCase(List<Car> cars, string checkThisCargo)
    {
        foreach (var car in cars)
        {
            string cargoType = car.CarCargo.Type;
            int power = car.CarEngine.Power;

            if (cargoType == checkThisCargo && power > 250)
            {
                car.PrintCar();
            }
        }
    }

    private static void FragileCase(List<Car> cars, string checkThisCargo)
    {
        foreach (var car in cars)
        {
            string cargoType = car.CarCargo.Type;

            foreach (var tyre in car.Tyres)
            {
                double tyrePresure = tyre.Pressure;

                if (cargoType == checkThisCargo && tyrePresure < 1)
                {
                    car.PrintCar();
                    break; //First tyre
                }
            }
        }
    }

    private static List<Car> AddCars(int carCount)
    {
        List<Car> cars = new List<Car>();

        for (int carIndex = 0; carIndex < carCount; carIndex++)
        {
            string carData = Console.ReadLine();
            Car car = new Car(carData);

            cars.Add(car);
        }

        return cars;
    }
}