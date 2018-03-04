public interface IBuyer
{
    string Name { get; }
    long Food { get; }
    void BuyFood(IBuyer buyer);
}