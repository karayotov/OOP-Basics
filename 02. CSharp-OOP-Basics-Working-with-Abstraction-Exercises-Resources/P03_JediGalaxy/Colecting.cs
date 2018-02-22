using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Colecting
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = dimestions[0];
            int col = dimestions[1];

            int[,] matrix = BigBang(row, col);

            PrintMatrix(matrix);

            Console.WriteLine(ColectingHearths(matrix));
        }

        private static string ColectingHearths(int [,] matrix)
        {
            string loverData;
            string evilData;
            long sum = 0L;            //<------------------------------------------------

            Coordinates coordinates = new Coordinates();
            Evil evil = new Evil();
            Lover ivo = new Lover(sum);

            while ((loverData = Console.ReadLine()) != "Let the Force be with you")
            {

                evilData = Console.ReadLine();

                evil = new Evil(new Coordinates(evilData));

                matrix = evil.RemoveStars(matrix);

                int[] ivoS = loverData.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                ivo = new Lover(new Coordinates(loverData));

                ivo.ColectingStars(matrix, ivo.StarsColected);       //<------------------------------------------------

                //int xI = ivoS[0];
                //int yI = ivoS[1];

                //while (xI >= 0 && yI < matrix.GetLength(1))
                //{
                //    if (xI >= 0 && xI < matrix.GetLength(0) && yI >= 0 && yI < matrix.GetLength(1))
                //    {
                //        sum += matrix[xI, yI];
                //    }

                //    yI++;
                //    xI--;
                //}
            }
            return ivo.StarsColected.ToString();
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix.GetLength(1); colIndex++)
                {
                    Console.Write(matrix[rowIndex, colIndex] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] BigBang(int rowCount, int colCount)
        {
            int[,] matrix = new int[rowCount, colCount];

            int value = 0;
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < colCount; colIndex++)
                {
                    matrix[rowIndex, colIndex] = value++;
                }
            }

            return matrix;
        }
    }
}
