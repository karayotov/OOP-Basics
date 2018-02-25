using System;

public class Box
{
    public const int MIN_VALUE = 0;
    double length;
    double width;
    double height;

    public double Length {
        get
        {
            return length;
        }
        set
        {
            if (value <= MIN_VALUE)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            length = value;
        }
    }

    public double Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value <= MIN_VALUE)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            width = value;
        }
    }

    public double Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value <= MIN_VALUE)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            height = value;
        }
    }

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