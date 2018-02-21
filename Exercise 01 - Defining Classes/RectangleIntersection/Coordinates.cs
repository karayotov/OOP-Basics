using System;

public class Coordinates
{
    public double X { get; set; }
    public double Y { get; set; }

    public Coordinates(double x, double y)
    {
        X = x;
        Y = y;
    }
    public Coordinates(Coordinates topLeft, double width, double height)
    {
        X = topLeft.X + width;
        Y = topLeft.Y + height;
    }
}