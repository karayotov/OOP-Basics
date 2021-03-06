﻿public class Space
{
    int[,] matrix;

    public int[,] Matrix { get => matrix; set => matrix = value; }

    public Space(int rowCount, int colCount)
    {
        int value = 0;

        var m = new int[rowCount, colCount];

        for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
        {
            for (int colIndex = 0; colIndex < colCount; colIndex++)
            {
                m[rowIndex, colIndex] = value++;
            }
        }
       
        this.Matrix = m;
    }
}