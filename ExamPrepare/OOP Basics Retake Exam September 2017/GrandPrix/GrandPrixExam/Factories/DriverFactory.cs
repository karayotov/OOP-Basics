using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DriverFactory
{
    public Driver CreateDriver(List<string> inputData)
    {
        //•	RegisterDriver {type} {name} {hp} {fuelAmount} Ultrasoft {tyreHardness} {grip}

        string type, name;
        Car car;

        CarFactory carFactory = new CarFactory();
         
        type = inputData[0];
        name = inputData[1];
        car = carFactory.GetCar(inputData.Skip(2).ToList());

        switch (type)
        {
            case "AggressiveDriver":
                return new AggressiveDriver(name, car);

            case "EnduranceDriver":
                return new EnduranceDriver(name, car);

            default:
                throw new ArgumentException(Messages.missingDriverType);
        }
    }
}
