using System;
using System.Text;

public class Book
{
    private const int MIN_LENGHT = 3;
    private const int MIN_PRICE = 0;
    private string outhor;
    private string title;
    private decimal price;


    public Book(string author, string title, decimal price)
    {
        Author = author;
        Title = title;
        Price = price;
    }

    public virtual string Author
    {
        get { return outhor; }
        protected set
        {
            string[] names = value.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            if (names.Length > 1)
            {
                if (char.IsDigit(names[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }
            outhor = value;
        }
    }

    public virtual string Title
    {
        get { return title; }  //<----------------get => title;
        protected set
        {
            if (value?.Length < MIN_LENGHT)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    public virtual decimal Price
    {
        get { return price; }
        protected set
        {
            if (value <= MIN_PRICE)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append("Type: ").Append(GetType().Name)
            .Append(Environment.NewLine)
            .Append("Title: ").Append(Title)
            .Append(Environment.NewLine)
            .Append("Author: ").Append(Author)
            .Append(Environment.NewLine)
            .Append(String.Format("Price: {0:f2}", Price));

        return stringBuilder.ToString();
    }
}