using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static FamilyTree family;
    static void Main(string[] args)
    {
        family = new FamilyTree();

        Person person = GetPerson(Console.ReadLine());

        family.AddToFamily(person);

        AddMoreToFamily();

        DeleteIncompleteData();

        Person extractedPerson = ExtractThisGuyFromFamily(person);

        Console.WriteLine(extractedPerson.ToString());

        PrintAllParents(person);

        PrintAllChiildren(person);


    }

    private static void DeleteIncompleteData()
    {
        family.Family.RemoveAll(m => m.CompletePerson == false);
    }

    private static Person ExtractThisGuyFromFamily(Person person)
    {
        Person member = person.Name != null ? family.Family.First(m => m.Name == person.Name) : family.Family.First(m => m.BirthDate == person.BirthDate);

        family.Family.Remove(member);

        return member;
    }

    private static void PrintAllParents(Person person)
    {
        DateTime parentControlDate = person.BirthDate.AddYears(-18);
        DateTime parentControlOlder = person.BirthDate.AddYears(-40);

        List<Person> parents = family.Family.Where(m => m.BirthDate < parentControlDate && m.BirthDate > parentControlOlder).ToList();

        Console.WriteLine("Parents:");

        foreach (Person parent in parents)
        {
            Console.WriteLine(parent.ToString());
        }
    }

    private static void PrintAllChiildren(Person person)
    {
        DateTime childrenControlDate = person.BirthDate.AddYears(18);

        List<Person> children = family.Family.Where(m => m.BirthDate > childrenControlDate).ToList();

        Console.WriteLine("Children:");
        foreach (Person child in children)
        {
            Console.WriteLine(child.ToString());
        }

    }

    private static void AddMoreToFamily()
    {
        string dataStr;

        while ((dataStr = Console.ReadLine()) != "End")
        {
            string[] data = dataStr.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

            Person person = GetPerson(data[0]);

            family.AddToFamily(person);

            if (data.Length > 1)
            {
                person = GetPerson(data[1]);

                family.AddToFamily(person);
            }
        }
    }

    private static Person GetPerson(string personStr)
    {
        string[] data = personStr.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        Person person;

        if (data.Length > 2)
        {
            person = new Person(data[0] + " " + data[1], StringToDateTimeConverter(data[2]));
            
        }
        else if(data.Length > 1)
        {
            person = new Person(data[0] + " " + data[1]);
        }
        else
        {
            person = new Person(StringToDateTimeConverter(data[0]));
        }

        return person;
    }

    private static DateTime StringToDateTimeConverter(string dateStr)
    {
        return DateTime.ParseExact(dateStr, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
    }
}