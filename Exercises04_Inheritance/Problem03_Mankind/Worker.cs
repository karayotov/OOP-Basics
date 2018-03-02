using System;
using System.Text;

public class Worker : Human
{
    private double weekSalary;
    private double hoursPerDay;

    public Worker(string firstName, string secondName, double weekSalary, double hours) : base(firstName, secondName)
    {
        HoursPerDay = hours;
        WeekSalary = weekSalary;
    }

    public double WeekSalary
    {
        get { return weekSalary; }
        private set
        {
            if (value < 10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {weekSalary}");
            }
            weekSalary = value;
        }
    }

    public double HoursPerDay
    {
        get { return hoursPerDay; }
        private set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {hoursPerDay}");
            }
            hoursPerDay = value;
        }
    }

    private double SalaryPerHour()
    {
        return WeekSalary / (HoursPerDay * 5.0);
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append($"First Name: {FirstName}")
            .Append(Environment.NewLine)
            .Append($"Last Name: {SecondName}")
            .Append(Environment.NewLine)
            .Append($"Week Salary: {WeekSalary:f2}")
            .Append(Environment.NewLine)
            .Append($"Hours per day: {HoursPerDay:f2}")
            .Append(Environment.NewLine)
            .Append($"Salary per hour: {SalaryPerHour():f2}")
            .Append(Environment.NewLine);

        return stringBuilder.ToString();
    }
}