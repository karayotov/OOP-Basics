using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Family
{
    private List<Person> people;

    public Family()
    {
        people = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.people.Add(member);
    }

    public Person GetOldestMember()
    {
        Person person = people.GroupBy(p => p.Age > 30).OrderBy(a => a = a);

        return person;
    }
}