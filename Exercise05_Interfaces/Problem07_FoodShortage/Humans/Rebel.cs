public class Rebel : Human
{
    public const int CAPACITY = 5;
    private string group;
    private long food;

    public long Food
    {
        get { return food; }
        set { food = value; }
    }

    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    public Rebel(string name, string age, string group): base(name, age)
    {
        Group = group;
    }

}