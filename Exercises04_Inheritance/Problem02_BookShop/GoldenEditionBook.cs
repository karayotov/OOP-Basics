using System;

class GoldenEditionBook:Book
{
    private const decimal GOLDEN_BONUS = 1.30M;
    public GoldenEditionBook(string outhor, string title, decimal price):base(outhor, title, price)
    {

    }
    public override decimal Price
    {
        get => base.Price * GOLDEN_BONUS;
    }
}