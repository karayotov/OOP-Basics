using System;
using System.Collections.Generic;
using System.Text;

public class Food
{
    public int PointsOfHappiness { get; private set; }

    public Food(int pointsOfHappiness)
    {
        PointsOfHappiness = pointsOfHappiness;
    }
}