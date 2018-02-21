
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

        bool firstXCase = firstRec.TopLeftPoint.X <= secondRec.BottomRightPoint.X;
        bool secondXCase = firstRec.BottomRightPoint.X >= secondRec.TopLeftPoint.X;
        bool firstYCase = firstRec.TopLeftPoint.Y >= secondRec.BottomRightPoint.Y;
        bool secondYCase = firstRec.BottomRightPoint.Y <= secondRec.TopLeftPoint.Y;

                                        //RectA.X1 < RectB.X2
                                        //RectA.X2 > RectB.X1
                                        //RectA.Y1 > RectB.Y2
                                        //RectA.Y2 < RectB.Y1

        if (firstXCase && secondXCase && firstYCase && secondYCase)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
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
            double x = double.Parse(data[3]);
            double y = double.Parse(data[4]);
            double width = double.Parse(data[1]);
            double height = double.Parse(data[2]);
            double bottomX = width + x;
            double bottomY = height + y;

            Coordinates topLeft = new Coordinates(x, y);
            Coordinates bottomRight = new Coordinates(topLeft, bottomX, bottomY);
            Rectangle rectangle = new Rectangle(name, topLeft, bottomRight);

            list.Add(rectangle);
        }

        return list;
    }
}