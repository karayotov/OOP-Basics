using System;
using System.Collections.Generic;
using System.Linq;

class Family
{

    public List<Person> people = new List<Person>();

    private List<Person> People
    {
        get { return people; }
        set { people = value; }
    }

    public void AddMember(int peopleMustAdd)
    {
        for (int i = 0; i < peopleMustAdd; i++)
        {
            string[] input = Console.ReadLine().Split();

            string nameOfPerson = input[0];
            int ageOfPerson = int.Parse(input[1]);

            Person person = new Person(nameOfPerson, ageOfPerson);
            this.People.Add(person);
        }
    }

    public Person GetOldestMember()
    {
        return People.OrderByDescending(p => p.Age).First();
    }
}