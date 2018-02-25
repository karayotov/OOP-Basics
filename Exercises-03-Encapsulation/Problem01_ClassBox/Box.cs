using System;

public class Box
{
    double length;
    double width;
    double height;

    private double Length { get => length; set => length = value; }
    private double Width { get => width; set => width = value; }
    private double Height { get => height; set => height = value; }

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    public double CalculateSurfaceArea()
    {
        return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
    }

    public double CalculateLateralSurface()
    {
        return 2 * Length * Height + 2 * Width * Height;
    }

    public double CalculateVolume()
    {
        return Length * Width * Height;
    }
}