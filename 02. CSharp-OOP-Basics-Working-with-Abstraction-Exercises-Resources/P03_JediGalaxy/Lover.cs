﻿using System;
using System.Collections.Generic;
using System.Text;
public class Lover
{
    Coordinates location;
    long starsColected;

    public long StarsColected { get => starsColected; set => starsColected = value; }
    internal Coordinates Location { get => location; set => location = value; }
    public Lover()
    {

    }
    public Lover(long stars, Coordinates loc)
    {
        Location = location;
        StarsColected = stars;
        Location = loc;
    }
    public void ColectingStars(Space galaxy, long sum)
    {
        var matrix = galaxy.Matrix;
        while (Location.Row >= 0 && Location.Col < matrix.GetLength(1))
        {
            if (Location.Row >= 0 && Location.Row < matrix.GetLength(0) && Location.Col >= 0 && Location.Col < matrix.GetLength(1))
            {
                sum += matrix[Location.Row, Location.Col];
            }

            Location.Col++;
            Location.Row--;
        }
        StarsColected = sum;
    }
}