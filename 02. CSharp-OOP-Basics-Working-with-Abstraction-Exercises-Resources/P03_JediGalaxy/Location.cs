using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Coordinates
{
    int row;
    int col;

    public int Row { get => row; set => row = value; }
    public int Col { get => col; set => col = value; }
    public Coordinates()
    {
        Row = row;
        Col = col;
    }
    public Coordinates(string input)
    {
        int[] evilLocation = input
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        Row = evilLocation[0];
        Col = evilLocation[1];
    }
}