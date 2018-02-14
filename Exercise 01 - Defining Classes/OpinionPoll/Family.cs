using System;
using System.Collections.Generic;
using System.Linq;

public class Family
{

    public List<Person> people = new List<Person>();

    private List<Person> People
    {
        get { return people; }
        set { people = value; }
    }

    public List<Person> AddMember(int peopleMustAdd)
    {
        for (int i = 0; i < peopleMustAdd; i++)
        {
            string[] input = Console.ReadLine().Split();

            string nameOfPerson = input[0];
            int ageOfPerson = int.Parse(input[1]);

            Person person = new Person(nameOfPerson, ageOfPerson);
            this.People.Add(person);
        }
        return People;
    }

    public void PrintOldersAlphabetical(List<Person> olderPeople)
    {
        olderPeople = People.OrderBy(a => a.Name).ToList();

        foreach (var human in olderPeople)
        {
            if (human.Age > 30)
            {
                Console.WriteLine($"{human.Name} - {human.Age}");
            }
        }
    }
}