using System;

public class StartUp
{
    static void Main(string[] args)
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        DateModifier dateModifier = new DateModifier();

        int days = dateModifier.GetDays(firstDate, secondDate);

        Console.WriteLine(days);
    }
}