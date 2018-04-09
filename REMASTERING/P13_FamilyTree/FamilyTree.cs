using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class FamilyTree
{
    public FamilyTree()
    {
        this.Family = new List<Person>();

    }

    public List<Person> Family { get; set; }
    public object Foreach { get; internal set; }

    public void AddToFamily(Person person)
    {

        if (this.Family.FirstOrDefault(c => c.Name == person.Name && c.Name != null) != null)
        {
            if (person.BirthDate != default(DateTime))
            {
                this.Family.FirstOrDefault(c => c.Name == person.Name).SetDate(person.BirthDate);
            }
            return;
        }

        if (this.Family.FirstOrDefault(c => c.BirthDate == person.BirthDate && c.BirthDate != default(DateTime)) != null)
        {
            if (person.Name != null)
            {
                this.Family.FirstOrDefault(c => c.BirthDate == person.BirthDate).SetName(person.Name);
            }
            return;
        }

        this.Family.Add(person);
    }
}
