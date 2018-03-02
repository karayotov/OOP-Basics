using System;
using System.Linq;
using System.Text;

public class Student : Human
{
    private string facultyNumber;

    public string FacultyNumber
    {
        get { return facultyNumber; }
        private set
        {
            if (value.Length < 5 || value.Length > 10
                || !value.ToCharArray().All(x => char.IsDigit(x) || char.IsLetter(x)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }

    public Student(string firstName, string secondName, string facultyNum) : base(firstName, secondName)
    {
        FacultyNumber = facultyNum;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"First Name: {FirstName}")
            .Append(Environment.NewLine)
            .Append($"Last Name: {SecondName}")
            .Append(Environment.NewLine)
            .Append($"Faculty number: {FacultyNumber}")
            .Append(Environment.NewLine);
        return stringBuilder.ToString();
    }
}