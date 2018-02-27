using System;
using System.Text;

class Person
{
    private const int MIN_VALUE = 0;
    private const int MIN_LENGTH = 2;
    private string name;
    private int age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual string Name
    {
        get => this.name; 
        protected set
        {
            if (value?.Trim().Length <= MIN_LENGTH)                  // <-----------experiment with ? and Thrim()
            {
                throw new ArgumentException("Name's length should not be less than 3 symbols!");
            }
            name = value;
        }
    }

    public virtual int Age
    {
        get => age; 
        protected set
        {
            if (value < MIN_VALUE)
            {
                throw new ArgumentException("Age must be positive!");
            }
            age = value;
        }
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"Name: {Name}, Age: {Age}");

        return stringBuilder.ToString();
    }
}