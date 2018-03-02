public class Kitten : Animal
{
    private const string Gender = "Female";

    public Kitten(string name, int age) : base(name, age, Gender)
    {

    }

    public override string ProduceSound()
    {
        return "Meow";
    }
}