using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    public string Model { get; set; }
    public Engine CarEngine { get; set; }
    public Cargo CarCargo { get; set; }
    public List<Tyre> Tyres { get; set; }

    public void Add(string singleCarData)
    {
        string[] data = singleCarData.Split();

        Model = data[0];
        CarEngine = new Engine(int.Parse(data[1]), int.Parse(data[2]));
        CarCargo = new Cargo(int.Parse(data[3]), data[4]);

    }

}
//CarColection
    //Car
    //<Model>
    //Engine

    //Cargo

    //TyreColection(List)
        //Tyre * 4
