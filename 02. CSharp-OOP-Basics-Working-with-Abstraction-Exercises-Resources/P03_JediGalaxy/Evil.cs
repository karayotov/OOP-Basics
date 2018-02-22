using System;
using System.Collections.Generic;
using System.Text;
class Evil
{
    Coordinates location;
    Coordinates Location { get => location; set => location = value; }

    public Evil()
    {
        Location = location;
    }

    public Evil(Coordinates loc)
    {
        Location = loc;
    }

    public int[,] RemoveStars(int [,] matrix)
    {

        while (Location.Row >= 0 && Location.Col >= 0)
        {
            if (Location.Row >= 0 && Location.Row < matrix.GetLength(0) && Location.Col >= 0 && Location.Col < matrix.GetLength(1))
            {
                matrix[Location.Row, Location.Col] = 0;
            }
            Location.Row--;
            Location.Col--;
        }
        
        return matrix;
    }
}//while (row >= 0 && col >= 0)
 //{
 //    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
 //    {
 //        matrix[row, col] = 0;
 //    }
 //    row--;
 //    col--;
 //}