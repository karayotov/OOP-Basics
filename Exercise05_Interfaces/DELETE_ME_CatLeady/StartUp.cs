using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static List<Cat> ginka;
    public static void Main(string[] args)
    {

        ginka = new List<Cat>();

        string inputLine;

        while ((inputLine = Console.ReadLine()) != "End")
        {
            CatsOrganizer(inputLine);
        }

        string name = Console.ReadLine();

        Console.WriteLine(ginka.First(c => c.Name == name).ToString());
    }

    private static void CatsOrganizer(string inputLine)
    {
        List<string> dataList = inputLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        string catKind = dataList[0];

        dataList.RemoveAt(0);

        Cat cat;

        switch (catKind)
        {
            case "Siamese":

                cat = new Siamese(dataList[0], int.Parse(dataList[1]));
                break;
            case "Cymric":

                cat = new Cymric(dataList[0], double.Parse(dataList[1]));
                break;
            case "StreetExtraordinaire":

                cat = new StreetExtraordinaire(dataList[0], int.Parse(dataList[1]));
                break;
            default:
                throw new ArgumentException("ni staa");
        }

        ginka.Add(cat);


    }
}