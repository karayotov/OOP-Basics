public class Pet : IBirthable
{
    private string name;
    private string birthdate;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Birthdate
    {
        get { return birthdate; }
        set { birthdate = value; }
    }

    public Pet(string name, string birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }
}