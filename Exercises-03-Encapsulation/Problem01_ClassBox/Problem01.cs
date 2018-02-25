using System;
class Problem01
{
    static void Main(string[] args)
    {
        Box box = new Box(double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine()));

        Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():f2}");
        Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurface():f2}");
        Console.WriteLine($"Volume - {box.CalculateVolume():f2}");
    }
}