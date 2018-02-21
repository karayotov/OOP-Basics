
using System;
using System.Collections.Generic;
using System.Linq;

class RectangularIntersection
{
    static void Main(string[] args)
    {
        int[] inputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rectangularsCount = inputs[0];
        int commandsCount = inputs[1];

        List<Rectangle> shapes = AddShapes(rectangularsCount);

        ReadCommand(commandsCount, shapes);
    }

    private static void ReadCommand(int count, List<Rectangle> shapes)
    {
        for (int i = 0; i < count; i++)
        {
            string[] rectangularsToCheck = Console.ReadLine().Split().ToArray();
            string firstShape = rectangularsToCheck[0];
            string secondShape = rectangularsToCheck[1];

            IntersectionDiagnostic(firstShape, secondShape, shapes);
        }
    }

    private static void IntersectionDiagnostic(string firstShape, string secondShape, List<Rectangle> shapes)
    {
        Rectangle firstRec = ExtractRectangular(firstShape, shapes);
        Rectangle secondRec = ExtractRectangular(secondShape, shapes);

        bool firstCase = 
    }

    private static Rectangle ExtractRectangular(string comparingName, List<Rectangle> shapes)
    {
        Rectangle rectangle = new Rectangle();

        foreach (var shape in shapes)
        {
            if (shape.Id == comparingName)
            {
                rectangle = shape;
            }
        }
        return rectangle;
    }

    private static List<Rectangle> AddShapes(int count)
    {
        List<Rectangle> list = new List<Rectangle>();

        for (int i = 0; i < count; i++)
        {
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string name = data[0];
            int x = int.Parse(data[3]);
            int y = int.Parse(data[4]);
            int width = int.Parse(data[1]);
            int height = int.Parse(data[2]);
            int bottomX = width + x;
            int bottomY = height + y;

            Coordinates topLeft = new Coordinates(x, y);
            Coordinates bottomRight = new Coordinates(topLeft, bottomX, bottomY);
            Rectangle rectangle = new Rectangle(name, topLeft, bottomRight);

            list.Add(rectangle);
        }

        return list;
    }
}