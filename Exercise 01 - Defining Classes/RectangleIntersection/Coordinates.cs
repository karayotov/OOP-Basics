using System;

public class Coordinates
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordinates(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Coordinates(Coordinates topLeft, int width, int height)
    {
        X = topLeft.X + width;
        Y = topLeft.Y + height;
    }
}