public class Ferrari : ICar
{
    public string Model() { return "488-Spider"; }
    public string Brake() {return "Brakes!"; }
    public string Accelerate() {return "Zadu6avam sA!"; }
    public string Driver { get; private set; }

    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public override string ToString()
    {
        return $"{Model()}/{Brake()}/{Accelerate()}/{this.Driver}";
    }
}