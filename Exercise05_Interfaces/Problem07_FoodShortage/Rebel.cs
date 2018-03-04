public class Rebel : IBuyer
{
    private const int BOUGHT_FOOD = 10;
    private string name;
    private string age;
    private string group;
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

    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    public Rebel(string name, string age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }
}