using System;
using System.Collections.Generic;
using System.Text;

public class Person
{

    public Person()
    {
    }

    public Person(string name)
    {
        this.Name = name;
    }

    public Person(DateTime birthDate)
    {
        this.BirthDate = birthDate;

    }

    public Person(string name, DateTime birthDate)
    {
        this.Name = name;
        this.BirthDate = birthDate;
        ValidateCompletePerson();
    }



    public string Name { get; set; }

    public DateTime BirthDate { get; set; }

    public bool CompletePerson { get; set ; }

    private void ValidateCompletePerson()
    {
        if (this.Name != null && this.BirthDate != default(DateTime))
        {
            this.CompletePerson = true;
        }
    }

    public void SetName(string name)
    {
        this.Name = name;
        ValidateCompletePerson();
    }

    public void SetDate(DateTime birthDate)
    {
        this.BirthDate = birthDate;
        ValidateCompletePerson();
    }

    public override string ToString()
    {
        return $"{this.Name} {this.BirthDate.ToString("d/M/yyyy")}";
    }
}