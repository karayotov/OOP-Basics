using System;

class Problem02
{
    static void Main(string[] args)
    {
        try
        {
            Box box = new Box(double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine()));

            Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurface():f2}");
            Console.WriteLine($"Volume - {box.CalculateVolume():f2}");
        }
        catch (ArgumentException e)
        {

            Console.WriteLine(e.Message);
        }
    }
}