using System;
using System.Collections.Generic;
using System.Text;

public class Human : ICitizen
{
    private string name;
    private string age;
    private string id;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Age
    {
        get { return age; }
        set { age = value; }
    }
   
    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public Human(string name, string age, string id)
    {
        Name = name;
        Age = age;
        Id = id;
    }
}