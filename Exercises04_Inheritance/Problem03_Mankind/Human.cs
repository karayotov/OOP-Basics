using System;

public class Human
{
    private string firstNAme;
    private string secondName;

    public virtual string FirstName
    {
        get { return firstNAme; }// Validation needed
        protected set
        {
            if (value?.Length < 4)
            {
                throw new ArgumentException($"Expected length at least 4 symbols! Argument: {firstNAme}");
            }
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {firstNAme}");
            }
            firstNAme = value;
        }
    }

    public virtual string SecondName
    {
        get { return secondName; }// Validation needed
        protected set
        {
            if (value?.Length < 3)
            {
                throw new ArgumentException($"Expected length at least 4 symbols! Argument: {secondName}");
            }
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: { secondName}");
            }
            secondName = value;
        }
    }

    public Human(string firstName, string secondName)
    {
        FirstName = firstName;
        SecondName = secondName;
    }
}