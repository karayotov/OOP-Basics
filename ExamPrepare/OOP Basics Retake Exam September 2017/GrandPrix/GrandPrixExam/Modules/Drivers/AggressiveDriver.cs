using System;
using System.Collections.Generic;
using System.Text;

public class AggressiveDriver : Driver
{

    private const double FUEL_CONSUMPTION = 2.7;

    private const double SPEED_COEFF = 1.3;



    public AggressiveDriver(string name, Car car) 
        : base(name, car, FUEL_CONSUMPTION){}

    public override double Speed => base.Speed * SPEED_COEFF;
}
