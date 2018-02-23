﻿using System;
using System.Linq;
public class Colecting
{
    static void Main()
    {
        string galaxyData = Console.ReadLine();
        int[] dimestions = galaxyData
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int row = dimestions[0];
        int col = dimestions[1];

        Space galaxy = new Space(dimestions[0], dimestions[1]);

        Console.WriteLine(ColectingHearths(galaxy));
    }

    private static string ColectingHearths(Space galaxy)
    {
        string loverData;
        long sum = 0L;

        Coordinates coordinates = new Coordinates();
        Evil evil = new Evil();
        Lover ivo = new Lover(sum);

        while ((loverData = Console.ReadLine()) != "Let the Force be with you")
        {
            evil = new Evil(new Coordinates(Console.ReadLine()));
            evil.RemoveStars(galaxy.Matrix);

            ivo = new Lover(new Coordinates(loverData));
            ivo.ColectingStars(galaxy.Matrix, ivo.StarsColected);
        }
        return ivo.StarsColected.ToString();
    }
}
