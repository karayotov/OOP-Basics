using System;
using System.Collections.Generic;

public class Program
{
    public static List<IBirthable> creatures = new List<IBirthable>();
    static void Main(string[] args)
    {
        string readLine;

        while ((readLine = Console.ReadLine()) != "End")
        {
            IBirthable creature;

            string[] creatureData = readLine.Split();
            if (creatureData.Length == 5)
            {
                creature = new Human(creatureData[1], creatureData[2], creatureData[3], creatureData[4]);
            }
            else if (creatureData.Length == 3 && ContainsDate(creatureData))
            {
                creature = new Pet(creatureData[1], creatureData[2]);
            }
            else
            {
                continue; //Passing robots data
            }

            creatures.Add(creature);
        }

        string year = Console.ReadLine();

        PrintCorespondingDates(year);
       
        //AfterprintValidation(PrintCorespondingDates(year));
    }

    private static bool ContainsDate(string[] CreatureData)
    {
        int length = CreatureData[2].Split("/").Length;

        if (length == 3)
        {
            return true;
        }

        return false;
    }

    public static void AfterprintValidation(bool datesPrinted)
    {
        if (datesPrinted == false && creatures.Count == 0)
        {
            Console.WriteLine("<empty output>");
        }
    }

    private static bool PrintCorespondingDates(string year)
    {
        bool dateFound = false;

        foreach (var creature in creatures)
        {
            string extractedYear = creature.Birthdate.Split("/")[2];

            if (extractedYear == year)
            {
                Console.WriteLine(creature.Birthdate);
                dateFound = true;
            }
        }
        return dateFound;
    }
}
