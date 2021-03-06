﻿public class Human : ICitizen
{
    private string name;
    private string age;
    private string id;
    private string birtdate;

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

    public string Birthdate
    {
        get { return birtdate; }
        set { birtdate = value; }
    }
    public Human(string name, string age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }
}