using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    static void Main(string[] args)
    {
        string input;
        DraftManager draftManager = new DraftManager();

        while((input = Console.ReadLine()) != "Shutdown")
        {
            List<string> inputList = input.Split().ToList();

            string command = inputList[0];
            inputList = inputList.Skip(1).ToList();

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(inputList));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(inputList));
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draftManager.Mode(inputList));
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(inputList));
                    break;

            }
            
        }

        Console.WriteLine(draftManager.ShutDown());
    }
}