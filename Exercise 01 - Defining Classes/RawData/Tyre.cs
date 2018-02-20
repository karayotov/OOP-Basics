using System;
using System.Collections.Generic;
using System.Text;

public class Tyre
{

    public double Pressure { get; set; }
    public int Age { get; set; }

    public Tyre (double pressure, int age)
    {
        Pressure = pressure;
        Age = age;
    }

    public List<Tyre> AddTyres(string[] data)
    {
        List<Tyre> tyres = new List<Tyre>();

        for (int dataIndex = 5; dataIndex < data.Length; dataIndex++)
        {
            tyres.Add(new Tyre(double.Parse(data[dataIndex]), int.Parse(data[dataIndex])));
        }

        return tyres;
    }
}

//<Pressure>
//<Age>