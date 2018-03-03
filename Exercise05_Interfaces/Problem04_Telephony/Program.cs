using System;
using System.Collections.Generic;
using System.Linq;

//преписано от GitHub: vpaleshnikov

public class Program
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split();
        string[] sites = Console.ReadLine().Split();

        Smartphone smartphone = new Smartphone();

        for (int i = 0; i < numbers.Length; i++)
        {
            try
            {
                smartphone.Number = numbers[i];
                Console.WriteLine(smartphone.Calling());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        for (int i = 0; i < sites.Length; i++)
        {
            try
            {
                smartphone.Site = sites[i];
                Console.WriteLine(smartphone.Browsing());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}