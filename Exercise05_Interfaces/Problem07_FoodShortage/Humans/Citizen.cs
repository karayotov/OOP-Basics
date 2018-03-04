public class Citizen : Human
{
    public const int CAPACITY = 10;
    private string id;
    private string birtdate;
    
   
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

    public Citizen(string name, string age, string id, string birthdate): base(name, age)
    {
        Id = id;
        Birthdate = birthdate;
    }
}