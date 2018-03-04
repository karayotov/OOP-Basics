public class Citizen : ICitizen, IBuyer
{
    private const int BOUGHT_FOOD = 5;
    private string name;
    private string age;
    private string id;
    private string birtdate;
    private long food;
    public void BuyFood() { Food += BOUGHT_FOOD; }

    public long Food
    {
        get { return food; }
        set { food = value; }
    }

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
    public Citizen(string name, string age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }
}