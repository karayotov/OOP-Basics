using System;

class DefineAClassPerson
{
    static void Main(string[] args)
    {
        int peopleMustAdd = int.Parse(Console.ReadLine());
        Family family = new Family();

        family.AddMember(peopleMustAdd);

        Person oldestPerson = family.GetOldestMember();

        Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
    }
}