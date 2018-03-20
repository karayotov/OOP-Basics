using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarFactory
{
    public Car GetCar(List<string> inputLine)
    {
        int hp;
        double fuelAmount;
        Tyre tyre;
        TyreFactory tyreFactory;

        tyreFactory = new TyreFactory();
        hp = int.Parse(inputLine[0]);
        fuelAmount = double.Parse(inputLine[1]);
        tyre = tyreFactory.GetTyre(inputLine.Skip(4).ToList());

        return new Car(hp, fuelAmount, tyre);
    }
}
