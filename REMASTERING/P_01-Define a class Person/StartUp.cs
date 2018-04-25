
using System;

public class StartUp
{
    public static void Main()
    {
        int counter = int.Parse(Console.ReadLine());

        Family family = new Family();

        for (int i = 0; i < counter; i++)
        {
            string[] inputLine = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            string name = inputLine[0];
            int age = int.Parse(inputLine[1]);

            Person person = new Person(name, age);

            family.AddMember(person);
        }

        Person oldest = family.GetOldestMember();

        Console.WriteLine(oldest);
    }
}