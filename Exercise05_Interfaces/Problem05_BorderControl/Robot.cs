public class Robot : ICitizen
{
    private string id;
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public Robot(string model, string id)
    {
        Name = model;
        Id = id;
    }
}