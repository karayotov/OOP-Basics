using System;
using System.Collections.Generic;

public class Program
{
    public static List<ICitizen> citizens = new List<ICitizen>();
    static void Main(string[] args)
    {
        string readLine;

        while ((readLine = Console.ReadLine()) != "End")
        {
            ICitizen citizen;

            string[] citizenData = readLine.Split();
            if (citizenData.Length == 3)
            {
                citizen = new Human(citizenData[0], citizenData[1], citizenData[2]);
            }
            else
            {
                citizen = new Robot(citizenData[0], citizenData[1]);
            }

            citizens.Add(citizen);

        }
        string idValidator = Console.ReadLine();
        foreach (var citizen in citizens)
        {
            try
            {
                ValidateID(citizen, idValidator);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(citizen.Id);
            }
        }
    }

    public static void ValidateID(ICitizen citizen, string idValidator)
    {
        string idForCheck = citizen.Id.Substring(citizen.Id.Length - idValidator.Length);

        if (idForCheck == idValidator)
        {
            throw new ArgumentException("this is fake Id");
        }
    }
}
