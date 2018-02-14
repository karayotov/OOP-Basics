public class Person
{
    int age;
    string name;

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Person(string currName, int currAge)
    {
        this.Name = currName;
        this.Age = currAge;
    }
}